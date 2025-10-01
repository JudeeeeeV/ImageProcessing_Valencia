# Image Processing Program

This is a Windows Forms application built with C# that demonstrates basic image processing operations.  

It was created as part of the **Intelligent Systems 1** course assignment.  

## Features

- **Basic Mode**
  - Load and save images  
  - Copy image  
  - Apply invert filter  
  - Convert to grayscale  
  - Apply sepia filter  
  - Generate histogram  

- **Subtract Mode**
  - Load foreground and background images  
  - Subtract foreground from background  
  - Save subtracted result  
  - Clear loaded images
 
- **Convolution Matrix Mode**
  - Smooth filter  
  - Sharpen filter
  - Gaussian blur filter 
  - Mean removal filter
  - Emboss filters:
    - Laplacian
    - Horizontal + Vertical
    - All directions
    - Lossy
    - Horizontal only
    - Vertical only
   
- **Webcam Mode**
  - Detect and select available webcams  
  - Enable/disable live webcam preview
  - Gaussian blur filter 
  - Mean removal filter
  - Apply real-time filters to live feed:
    - Apply invert filter  
    - Convert to grayscale  
    - Apply sepia filter
    - Subtract (with threshold detection)
  - Show both original and processed webcam output side by side  

- **User-Friendly Interface**
  - Simple layout with dedicated sections for each mode (Basic, Subtract, Convolution, Webcam) 
  - Preview of input, output, foreground, and background images
  - Organized buttons for easy access to each operation 

## How to Run

1. Clone this repository.  
2. Locate the `ImageProcessing_Valencia.exe` file in the root folder of the project.  
3. Double-click `ImageProcessing_Valencia.exe` to launch the calculator.  

No installation or setup required.


---
