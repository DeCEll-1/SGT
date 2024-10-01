package SGT.SGT.Parser;

import com.fs.starfarer.api.graphics.SpriteAPI;
import sun.security.util.ArrayUtil;

import java.awt.*;
import java.awt.image.BufferedImage;
import java.nio.ByteBuffer;
import java.nio.FloatBuffer;
import java.nio.charset.StandardCharsets;
import java.util.Arrays;
import java.util.Collections;

public class ImageWorks {
    // https://github.com/ktekeli/img-stego

    private byte getByte(byte[] bits) {
        String bitString = "";
        for (int i = 0; i < 8; i++)
            bitString += bits[i];
        byte newpix = Byte.parseByte(bitString, 2);
        int dePix = (int) newpix;
        return (byte) dePix;
    }

    private byte[] getBits(byte simplepixel) {
        String byteString = Integer.toBinaryString(simplepixel);

        while (true) {
            if (byteString.length() == 8)
                break;

            byteString = "0" + byteString;
        }

        byte[] bitsArray = new byte[8];

        char[] charArray = byteString.toCharArray();
        for (int i = 0; i < charArray.length; i++) {
            char bit = charArray[i];
            bitsArray[i] = (byte) Integer.parseInt(String.valueOf(bit));
        }

        return bitsArray;

//        Array.Reverse(bitsArray);
    }


    /*This method is used to extract data from pixels*/
    public byte extract(Color pixel) {

        byte[] RedBits = getBits((byte) pixel.getRed());
//        RedBits = reverseArray(RedBits);
        byte[] GreenBits = getBits((byte) pixel.getGreen());
//        GreenBits = reverseArray(GreenBits);
        byte[] BlueBits = getBits((byte) pixel.getBlue());
//        reverseArray(BlueBits);
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

    public String BitmapToText(BufferedImage encodedImage, SpriteAPI texture) {


        String outputText = "";

        /* Decoding process */
        //region Decoding

        int k = 0;
        String tlength = "";

        //region length_extract

        for (int j = 3; j < 16; j++) {

            // y * width + x

            Color pixelToDecode = new Color((int) encodedImage.getRGB((int) (texture.getWidth() - j - 1), (int) (texture.getHeight() - 1)));
            byte delength = extract(pixelToDecode);

            String ourChar = new String(new byte[]{delength}, StandardCharsets.UTF_8);

            tlength += ourChar;
        }

        int length = Integer.parseInt(tlength.toString());

        //endregion

        k = 0;

        for (int i = 0; i < texture.getHeight(); i++) {
            for (int j = 0; j < texture.getWidth(); j++) {
                if (k < length) {
                    Color pixelToDecode = new Color((int) encodedImage.getRGB(j, i));
                    byte demsg = extract(pixelToDecode);
                    String messageChar = new String(new byte[]{demsg}, StandardCharsets.UTF_8);
                    outputText += messageChar;
                    k++;
                }
            }
        }

        //endregion

        return outputText.replace("\0", "");
    }

    private int coordinateToIndex(int x, int y, int width) {
        return y * width + x;
    }

    private byte[] reverseArray(byte[] array) {
        for (int i = 0; i < array.length / 2; i++) {
            byte temp = array[i];
            array[i] = array[array.length - i - 1];
            array[array.length - i - 1] = temp;
        }

        return array;
    }
}
