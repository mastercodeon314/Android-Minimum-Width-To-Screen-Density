# Android-Minimum-Width-To-Screen-Density
A small utility to accurately convert Minimum width (dp) from the android developer options to screen density!

# Demo
https://github.com/mastercodeon314/Android-Minimum-Width-To-Screen-Density/assets/78676320/636fc96e-7cb8-4e50-8a54-4d5956ba80ce

# Background
Recently, I was informed about an awesome developer option in android called "Minimum Width."
This option when increased in value makes everything on the screen smaller, giving everything a much sharper look. By default, my S23 Ultra was set to 411 for this value.
However, setting this value to 481 made my screen much sharper adn crisper looking; getting even more out of the already amazing looking screen on the s23.
Naturally, i was curious if there was an adb command to change this value, and upon some research, I made some interesting discoveries. 

# Digging in
I started off with playing with the wm desnity command. This command does work, and does sort of the same thing as changing the Minimum Width developer option.
Theres a catch tho, for some reason, the value of wm density did not match what the value of Minimum Width reflected in the dev options. Stumped, I went to the SecSettings.apk file for answers. 
It was here that i found something i never expected. The Min width value in the developer options isnt actually a real setting in android. Its simply a converted value of the density in global settings!
