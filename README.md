# Android-Minimum-Width-To-Screen-Density
A small utility to accurately convert Minimum width (dp) from the android developer options to screen density!

# Demo
https://github.com/mastercodeon314/Android-Minimum-Width-To-Screen-Density/assets/78676320/636fc96e-7cb8-4e50-8a54-4d5956ba80ce

# Background
Recently, I was informed about an awesome developer option in android called "Minimum Width."
This option, when increased in value makes everything on the screen smaller, giving everything a much sharper look. By default, my S23 Ultra was set to 411 for this value.
However, setting this value to 481 made my screen much sharper and crisper looking, getting even more out of the already amazing looking screen on the s23.
Naturally, I was curious if there was an adb command to change this value, and upon some research, I made some interesting discoveries. 

# Digging in
I started off with playing with the wm density command. This command does work and does sort of the same thing as changing the Minimum Width developer option.
Theres a catch tho, for some reason, the value of wm density did not match what the value of Minimum Width reflected in the dev options. I scoured the internet for an answer on how to convert the density value to a minimum width value, and vice versa, but interestingly enough, no one knew how to do the conversion. 
Stumped, I went to the SecSettings.apk file for answers. 
It was here that I found something I never expected. The Min width value in the developer options isn’t a real setting in android. Its simply a converted value of the density in global settings!
In the SecSettings.apk, under ```com.android.settings.Display.DensityPreference```, you can see some code in the onDialogClosed function that takes the value the user puts into the Minimum Width settings under the dev options, and converts it to a screen density value based on the current resolution.

Fig 1. 
![image](https://github.com/mastercodeon314/Android-Minimum-Width-To-Screen-Density/assets/78676320/9c7d3ab0-3ce0-46c4-b325-1b25b2d739f4)

# Que The code
After asking the AI for some help, I was able to take this code, and reverse the process to do the opposite, convert a screen density value to a Minimum Width value. 
So naturally, I plugged this code into a simple winforms, grabbed a copy of AdvancedSharpAdbClient, made a few buttons, labels, and sliders, and bam! 
We now have a proper way reverse engineered straight from the android source code to accurately convert Minimum width to screen density and vice versa!

# Conclusion
If you have a good screen on your android device, especially if you are using the S series Samsung device, i HIGHLY recommend changing your default Minimum width value to at least 481 for 1440x3088 resolution. 
This will get you the most out of your screen for sharpest and clearest looking visuals. Apparently this is what they do on demo devices in store to give the display a crisper look. But from the factory, my device had a lower setting. Not anymore!
Enjoy y'all!

## References
- https://github.com/SharpAdb/AdvancedSharpAdbClient