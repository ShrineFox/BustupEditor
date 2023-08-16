# BustupEditor
You can use this GUI to extract & repack DDS images from bustup .BIN files found in Persona 5 Royal (PC/Switch). 
Previously known as BustupParamEditorGUI. See Releases for older versions that worked with Persona 5 (PS3).

![Image](https://i.imgur.com/cd66qTU.png)

## Features
- Import a .DAT file and it will automatically extract all nearby Bustup .BIN files (if present).
- Add/remove bustup parameter entries, reposition eye/mouth frames, change animation style, and preview animation frames.
- Export a new .DAT file (and automatically repack extracted .BINs if found).
- Save/load projects as .json so you can resume editing where you left off.
- Set a name for a selected bustup parameter entries so you can easily find it in the list.
- Copy the selected bustup entry's parameters, and Paste to apply positional offsets to all selected list entries.

## How to Use
1. Use [CriFSLibGUI](https://github.com/Sewer56/CriFsV2Lib/releases) to extract the contents from CPK files in ``Steam\steamapps\common\P5R\CPK``.
2. Extract the latest Release and run ``BustupEditor.exe``.
### Editing Dialog Portrait Bustups
1. Click on ``File`` > ``Import``.
2. Navigate to ``BASE.CPK_unpacked\BUSTUP\DATA`` and choose ``BUSTUP_PARAM.DAT``.
   (If you only want to edit position/entry data and not unpack/repack bustups, move this file out of the folder first).
3. Select the entry that you want to edit in the list. Right click and choose ``Open Image Folder``.
4. Use a program that can edit DDS files (such as Paint.NET) to edit and replace the images.
5. Re-select the entry in the program to reload the image preview.
6. Change the selected eye/mouth frame number in the bottom right to preview blinking/talking.
7. Use the offset options on the bottom left to re-align the eyes and mouth if needed.
8. Click on ``File`` > ``Export`` to choose a new location to save your modified ``.DAT`` to.
   (If you don't want to repack all bustups, which can take awhile, remove all but your edited ones from the ``Extracted`` folder).
### Editing Navigator Bustups
Same as above, but import  ``BASE.CPK_unpacked\FONT\ASSIST\MSGASSISTBUSTUPPARAM.DAT`` instead.

## Future Plans
- Reimplement support for the PS3 version of Persona 5.
- Support for bustup .BINs containing GNF (PS4).
