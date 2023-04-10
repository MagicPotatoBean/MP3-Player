# MP3-Player
 An MP3 player that utilises Windows Media Player

To add a library to your player, launch it and click "edit", then it will open a text file at C:\Users\<your_name>\Appdata\Roaming\MP3Radio\Directory.txt
However, this won't work when running this out of visual studios debugger, as it get confused and navigates to the \bin\debug directory

Once in the text file, add the filepath of a new text file in your folder of music.

You want to have the text file you just made follow the following structure:

	First 5 lines are for comments, below that is for songs, write songs in the format shown below.
	
	DisplayName;SongFileName.mp3
	
	Songs start below this line, with one song per line.
        
Please note that SongFileName.mp3 would not be the full path(e.g. C:\Users\etc.), rather just the name of the file and the extention.

There are a few bugs that i know about and would fix, however, i am too lazy :)
