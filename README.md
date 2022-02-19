# CS 8395 - Project Two - Augmented Reality Book Cover

## Overview
For this project, I created an AR book cover for the book *Cracking the Coding Interview* (CTCI) by Gayle Laakman McDowell. 
On the front cover, I display a workspace that contains a desk and chair with various objects on the table. The table 
contains a laptop with a code editor opened, notebook, and cup to represent the workspace of a software engineer. 
This AR cover represents to some extent that the book is about the software engineer interview process by showing 
what the workspace for a software engineer is like. 

![AR Front Cover for *Cracking the Coding Interview*](docs/images/book_cover_front.jpg)

On the back cover, I display a basic fact sheet about the book with an AR button rendered on top of the book as well in white.
When the AR button is clicked by hovering over it using your hand in view of the device camera, the fact sheet switches to 
my review of the book. The AR button lets you toggle between the fact sheet and review by clicking on it.

![AR Back Cover with Fact Sheet Overview](docs/images/book_cover_back_overview.jpg)

![AR Back Cover with Review](docs/images/book_cover_back_review.jpg)

**Drive Link to Video of AR Book Cover**

[Link to video](https://drive.google.com/file/d/1UfhfbcJ6oGlPixjZtjwlACo8W8Ofia-I/view?usp=sharing)

## Implementation

I implemented the AR book cover using Unity 2020.3.17f1 and Vuforia. The project contains the assets and code used for
the book cover as well as the necessary Vuforia package configurations. I used an Android phone with the ARCore SDK to 
execute the book cover program. So, the project only contains the necessary SDKs for compiling the program to Android. 
I executed the program on a Samsung S9+ phone.

## Installation

To run the project, make sure to first install Unity 2020.3.17f1 or a compatible version. Next, clone this
GitHub repository and open the project in Unity. Once opened, go into the Build Settings for Unity. Next, make sure that 
the Android build platform is selected and your Android device is selected in the Device dropdown 
in the build settings. Make sure that your Android phone has USB debugging enabled and is compatible
with ARCore. Then, execute Build and Run to build and execute the program on your connected phone. 

## Limitations

The main limitations for this project are that there are certain tracking issues where it takes a few 
seconds for the book cover to be detected in the world. So, there is a delay where the AR book cover does
not render quick enough once the actual book cover is detected. This issue is related to Vuforia, so there
is nothing much that can be done from a programming end. The AR button also has trouble detecting if it has
been clicked. This problem is also related to problems with Vuforia's AR tracking system. So, the button 
sometimes does not register clicks or misregisters clicks. 

## Running the program

To run the program once built, open up the ar-project-2-book-cover application on your Android phone.
Then, point the phone camera at the front cover for *Cracking the Coding Interview*. Once the 
front cover is detected, the program will render the 3D workspace scene on top of the book along with the book 
title and author in augmented text. To render the back cover, flip the book to reveal the back cover. Once the 
back cover is detected, the program will render the fact sheet overview for the book as augmented text
and a white square button on top of the book. Toggling the button will switch the displayed text from the 
fact sheet to the review of the book, both in augmented text. 
