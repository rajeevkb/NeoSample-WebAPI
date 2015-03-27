# NeoSample-WebAPI
ASPNET 5 Starter that includes Web API and Angular support out of the box
Run from the command line as VS2015 has not transitioned to dnx naming yet. 
Open root foler in a text editor, I'm using Brackets.

Runs on latest DNX runtime:
<pre>
Active Version           Runtime Architecture Location                     Alias
------ -------           ------- ------------ --------                     -----
       1.0.0-beta4-11351 clr     x86          C:\Users\Glenn\.dnx\runtimes
       1.0.0-beta4-11360 clr     x86          C:\Users\Glenn\.dnx\runtimes
  *    1.0.0-beta5-11380 clr     x86          C:\Users\Glenn\.dnx\runtimes default
</pre>


You'll need to install node. 
Note: Make sure you have a global install of both Gulp and Bower.

<pre>npm install -g gulp</pre>

<pre>npm install -g bower</pre>

to check all packages install by npm globally
<pre>npm list -g --depth=0</pre>
<pre>
C:\Users\Glenn\AppData\Roaming\npm
├── bower@1.3.12
└── gulp@3.8.11
</pre>

References:
https://github.com/gulpjs/gulp/blob/master/docs/getting-started.md
https://github.com/johnpapa/pluralsight-gulp


I'ts here. NeoSample for the angular and WebAPI folks

Get a copy via git clone or zip. Run dnu restore and the the project will load the gulp and bower packages needed.

Run <pre>dnu restore</pre>
then in src/NeoSample run <pre>dnx . web</pre>

Browse to <pre>http://localhost:5003/clientsrc/index.html</pre> for the angular app



