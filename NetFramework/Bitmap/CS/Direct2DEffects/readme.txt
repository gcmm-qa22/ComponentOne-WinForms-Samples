Direct2DEffects
----------------------------------------
Demonstrates applying Direct2D effects to the image in C1Bitmap

This sample loads an image in C1Bitmap, converts it to Direct2D bitmap, applies various effects, then converts back to C1Bitmap and
then to the standard Bitmap object that can be assigned to the Image property of the PictureBox control.

When the user clicks the Export button the image is converted to Direct2D bitmap, then used as the source for a Grayscale effect.
The result is imported into another instance of C1Bitmap, then stored to a file.