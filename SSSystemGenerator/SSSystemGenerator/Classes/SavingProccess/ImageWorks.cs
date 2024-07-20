using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEmbeddingInImageTest
{
    public class ImageWorks
    { // https://github.com/ktekeli/img-stego

        private byte getByte(byte[] bits)
        {
            String bitString = "";
            for (int i = 0; i < 8; i++)
                bitString += bits[i];
            byte newpix = Convert.ToByte(bitString, 2);
            int dePix = (int)newpix;
            return (byte)dePix;
        }

        private byte[] getStringBits(string data)
        {
            byte[] text = System.Text.ASCIIEncoding.ASCII.GetBytes(data);
            BitArray bits = new BitArray(text);
            bool[] boolarray = new bool[bits.Count];
            bits.CopyTo(boolarray, 0);
            byte[] bitsArray = boolarray.Select(bit => (byte)(bit ? 1 : 0)).ToArray();
            Array.Reverse(bitsArray);
            return bitsArray;
        }

        private byte[] getBits(byte simplepixel)
        {
            int pixel = 0;
            pixel = (int)simplepixel;
            BitArray bits = new BitArray(new byte[] { (byte)pixel });
            bool[] boolarray = new bool[bits.Count];
            bits.CopyTo(boolarray, 0);
            byte[] bitsArray = boolarray.Select(bit => (byte)(bit ? 1 : 0)).ToArray();
            Array.Reverse(bitsArray);
            return bitsArray;
        }

        /*This method is used to embed data into pixels*/
        public Color embed(Color pixel, byte[] bits)
        {

            byte[] RedBits = getBits((byte)pixel.R);
            byte[] GreenBits = getBits((byte)pixel.G);
            byte[] BlueBits = getBits((byte)pixel.B);

            /*LSB substition of RGB values is done as following:
            Red: Last 3 bits, Green: Last 3 bits, Blue: Last 2 bits
            This process lets us embed 1 byte in each pixel*/

            #region BitChange
            RedBits[5] = bits[0];
            GreenBits[5] = bits[1];
            RedBits[6] = bits[2];
            RedBits[7] = bits[3];
            GreenBits[6] = bits[4];
            GreenBits[7] = bits[5];
            BlueBits[6] = bits[6];
            BlueBits[7] = bits[7];

            byte newRed = getByte(RedBits);
            byte newGreen = getByte(GreenBits);
            byte newBlue = getByte(BlueBits);

            return Color.FromArgb(newRed, newGreen, newBlue);
            #endregion

        }

        /*This method is used to extract data from pixels*/
        public byte extract(Color pixel)
        {
            byte[] RedBits = getBits((byte)pixel.R);
            byte[] GreenBits = getBits((byte)pixel.G);
            byte[] BlueBits = getBits((byte)pixel.B);
            byte[] BitsToDecrypt = new byte[8];

            BitsToDecrypt[0] = RedBits[5];
            BitsToDecrypt[1] = GreenBits[5];
            BitsToDecrypt[2] = RedBits[6];
            BitsToDecrypt[3] = RedBits[7];
            BitsToDecrypt[4] = GreenBits[6];
            BitsToDecrypt[5] = GreenBits[7];
            BitsToDecrypt[6] = BlueBits[6];
            BitsToDecrypt[7] = BlueBits[7];

            return getByte(BitsToDecrypt);
        }

        public Bitmap TextToBitmap(string text, Bitmap sourceImage)
        {
            string textbox = text;
            char[] textarray = text.ToArray();

            Bitmap mainImage = new Bitmap(sourceImage);

            /* Encoding process */
            #region Encoding

            //Embed type of data into last 3 pixels.
            #region type_embed
            // "tt1" is the code to define hidden data is a text message. (type:text:1)
            string[] type = new string[] { "t", "t", "1" };

            for (int j = 0; j < 3; j++)
            {
                Color pixel = mainImage.GetPixel(mainImage.Width - j - 1, mainImage.Height - 1);
                pixel = embed(pixel, getStringBits(type[j]));
                mainImage.SetPixel(mainImage.Width - j - 1, mainImage.Height - 1, pixel);
            }

            #endregion

            // Embed length of message into 13 pixels in reverse [3:15]
            #region length_embed

            string a = Convert.ToString((text).Length);
            a = a.PadLeft(13, '0'); //Zero-padding
            char[] b = a.ToArray();

            for (int j = 3; j < 16; j++)
            {
                string aString = Convert.ToString(b[j - 3]);
                Color pixel = mainImage.GetPixel(mainImage.Width - j - 1, mainImage.Height - 1);
                pixel = embed(pixel, getStringBits(aString));
                mainImage.SetPixel(mainImage.Width - j - 1, mainImage.Height - 1, pixel);
            }

            #endregion

            int k = 0;

            for (int i = 0; i < mainImage.Height; i++)
            {
                for (int j = 0; j < mainImage.Width; j++)
                {
                    if (k < textbox.Length)
                    {
                        string msg = Convert.ToString(textarray[k]);
                        Color pixel = mainImage.GetPixel(j, i);
                        pixel = embed(pixel, getStringBits(msg));
                        mainImage.SetPixel(j, i, pixel);
                        k++;
                    }

                }
            }

            #endregion

            return mainImage;
        }

        public string BitmapToText(Bitmap encodedImage)
        {

            string outputText = "";

            /* Decoding process */
            #region Decoding

            int k = 0;
            string tlength = "";

            #region length_extract

            for (int j = 3; j < 16; j++)
            {
                Color pixelToDecode = encodedImage.GetPixel(encodedImage.Width - j - 1, encodedImage.Height - 1);
                byte delength = extract(pixelToDecode);
                tlength += Convert.ToInt32(Encoding.ASCII.GetString(BitConverter.GetBytes(delength)));
            }

            int length = Convert.ToInt32(tlength);

            #endregion

            k = 0;

            for (int i = 0; i < encodedImage.Height; i++)
            {
                for (int j = 0; j < encodedImage.Width; j++)
                {
                    if (k < length)
                    {
                        Color pixelToDecode = encodedImage.GetPixel(j, i);
                        byte demsg = extract(pixelToDecode);
                        string messageChar = Encoding.ASCII.GetString(BitConverter.GetBytes(demsg));
                        outputText += messageChar;
                        k++;
                    }
                }
            }

            #endregion

            return outputText.Replace("\0", "");
        }

    }
}
