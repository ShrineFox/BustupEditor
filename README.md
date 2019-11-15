# BustupParamEditor GUI
This program shares features between previous projects [DDS2Tool](https://github.com/ShrineFox/DDS2Tool) and [BustupParamEditor](https://github.com/ShrineFox/BustupParamEditor).  
By specifying a path to either bustup_param.dat (found in ps3.cpk\bustup\data)  
or msgAssistBustupParam.dat (data.cpk\font\assist) and selecting a bustup,  
you can change the values for X and Y positioning of the mouth, eyes, or the entire bustup itself.  
![Image](https://i.imgur.com/080ZbZ4.png)

## Features
- Provide a path to your corresponding folder of bustup .BIN files to automatically extract the DDS images.
- Extracted DDS files are automatically converted to PNG.
- Preview the bustup parameters in real time while editing the positional values.
- Flip between animation frames for the mouth and eyes in the preview.
- Edit the extracted images and even repack them into a new .BIN file when you're satisfied.
- Quickly copy and paste positional values between bustups using the Edit menu.
- Thanks to [zarroboogs](https://github.com/zarroboogs), you can even change how bustups animate.
- Add parameters for brand new bustups or edit the ids of existing entries to fit your needs.

## Disclaimers
**Be sure to make copies of the original files before using this program!** 
Changes are saved directly to your selected files and cannot be undone.  
You have to edit the combined PNG files to preview custom bustup images in the program. (The preview doesn't use the uncombined DDS images).  
You must save over the original DDS files with your edits if you want to repack your custom bustup as a BIN. (The PNG files do not get converted back to DDS or repacked into the BIN.)
