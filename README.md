Not commited yet! Fixing bugs.

# 3DWriter Handwiritng edition
Use your 3D printer or plotter to write your homework/letters/etc. It's a fork of boy1dr software with amount of major improvements that let you to pretend that the result is something written not by a machine but with your hand.

# Improvements comparing to the boy1dr/3DWriter repo 
*The main point of the fork was to add the ability to create your own font. You can actually transfer your in real life handwriting and use it!
*5 times increased resolution (still not sure whatever is it good or not but it makes font making more comfortable)
*Handwriting modifiers that makes it more realistic
*New material design that makes it cooler :)
 
## How to use it
There are 3 main columns. 
- Text entry
- Preview
- GCode settings and handwriting modifiers

Once you have selected the font at the top left drop-down list, you can click right next to it on the "thumbnail" or "thmb" button to see a rendered letter set of the preinstalled font. There is a check button beside that "Simple fonts" which will alternate between the full set of fonts and a simple list.

Type some text into the Text input. Choose your scale in mm (there are some tips to help you) then click the Preview button to see your text rendered in the preview window.  
There are options for scaling up the preview render to make it easier to see what it might look like.  
Then you can activate some handwriting modifiers that will improve the reality of your works' look.
If your GCode settings are complete, just click "Generate GCode" and save the file for your printer.

![alt text](https://github.com/boy1dr/3DWriter/blob/master/interface.PNG "Interface")

## Make your own font

If you click on the menu button you will be able to find "Font editor" here. That's the feature that was finished about 70%  by boy1dr and I just made it till the usable state (still needs to be improved though). Here you can easily edit existing letters and even add new (for example, cyrillic, turkish and so on). You can also setup the input/output points to the letters - while rendering if previous letters has an output point and the current one has an input point - it would connect the letters in the same way as you do it when writing.

## Handwriting modifiers
At the right you can find some checkboxes - for example, letter connection or random letters movement. Use these to make it realistic and experiment with its settings!
## GCode settings
*Pay close attention here*

Bed X/Bed Y - Set the size of your printers bed here.  
Offset X/Offset Y - My pen is strapped to the side of my extruder so there is an offset.  
Pen up/Pen down - This is the height of the extruder/pen head from your build plate. Test this manually on your printer to get these.  
Travel / Draw speed - The speed at which the printer will move at. Slower is better.  

Line Spacing - The gap between the lines measured in 'units'.  
Letter Spacing - The gap between the letters measured in 'units'. Letters already have individual spacing but sometimes more is required.  

Home X/Y/Z - Before and after the printer does the writing you probably want to home all your axis. Untick those you don't.  
Dry run - Doesn't put the pen down, ever. This is so you can put your paper/card in place and see if it will go where you want it.  

Preview magnification makes no difference to the GCode.  
The GCode output is higher resolution than the preview window.  

## What is a 'unit' ?
The fonts are described in multiple x/y points as integers. Each font has a height around 200.
This isn't mm or pixels, it's just what was used to describe the strokes so i call them units.
This height is multiplied by the scale to render the fonts. Line and letter spacing is also multiplied by scale so the end result is proportional.

## Setting up your printer as a plotter (boy1dr quote)
At first i just used a rubber band to hold the pen on but it wiggled around too much so i printed a custom holder that attached firmly to my extruder. Then i printed mating piece and glued it to my pen (4 colour Bic pen).  
I made it so when the pen tip is retracted it is higher than my nozzle so i can keep the pen there all the time.  
Using a program like Pronterface you can manually move your extruder around to find the correct height for pen up & down, also the X and Y offset so you don't write off the edge of the page.

# Laser (boy1dr quote)
I equipped my 3D Printer with a cheap 1W UV laser from ebay which work quite well on a variety of materials.
I was using Marlin firmware but found there is no support for controlling a laser other than to connect the laser to the cooling fan and use M106/M107 to turn the laser on and off.

Repetier firmware has full laser support so after a bit of mucking about i managed to get it loaded on my GT2560 controller.

Since my printer has only 1 extruder, i decided to use the mosfet output normally used for a second extruder as a 12v power source for my laser.
Repetier has a great online configuration tool for setting things like which output to use for laser control.It made this process quite simple.

I used a LM7805 to regulate the 12v supply to 5v that the laser uses. 
I also connected a simple switch on the laser so i can be sure it's only going to work when i want it too :)


REPETIER USERS...
Please remove the laser on/off commands in 3DWriter. The commands required to activate the laser are put in to the GCode file automatically.

MARLIN USERS...
You don't have support for the laser GCode's so you need to specify your commands for laser ON and OFF in the program.
If you haven't already connected a laser, you can add a switch to the wires going to your part cooling fan so you can switch between cooling or laser.
If you do this, your commands will be...
Laser ON: M106
Laser Off: M107

ALL USERS...
Your cheap sub $25 1W laser from ebay will likely require 5v. Use an appropriate power supply for it, such as an LM7805 which are cheap and very very simple to wire in.

FOCUS...
All lasers need to be focused, i found that mine is 68mm from the build plate but that's because of where i mounted my laser. This will be different for ALL users.
I suggest using thick cardboard on your buildplate so you don't damage it. Make some simple/quick text, load it up in repetier host or pronterface etc, print it, raise your z-height, repeat until you get good results.




# USE AT YOUR OWN RISK
Boy1dr tested it on RepRap i3 clone and i have an ender 3 clone (Tronxy xy-2) on marlin 2.0 software. Can confirm that everything works ok.
I know from other software made for the ultimaker that sometimes the Z move is the wrong direction, me and boy1dr would advise that you simulate the gcode files prior to printing just to be sure you know what is going to happen. 
And as always when trying new software with your 3D Printer, keep one hand on the off switch :)

## Final notes
Boy1dr doesn't  claim to be the worlds best programmer, nor is he a self professed 3D Printer expert but he has many years of experience with both and he's pretty confident that this software works


### 15/11/2020 - Initial release!
