# NeoSample-WebAPI

ASPNET 5 Starter that includes Web API and Angular support out of the box.
Run from the command line as VS2015 has not transitioned to dnx naming yet.
Do not attemp to run in Visual Studio until next CTP release.

Open src or test  folder in a text editor, I'm using Brackets.
I usually open the folder NeoSample-WebAPI\src\NeoSample if I'm working on Web API or Angular since it contaions .jsscrc and other tooling files there.
 
Runs on latest DNX runtime:
<pre>
Active Version           Runtime Architecture Location                     Alias
------ -------           ------- ------------ --------                     -----
       1.0.0-beta4-11337 clr     x86          C:\Users\Glenn\.dnx\runtimes
       1.0.0-beta4-11351 clr     x86          C:\Users\Glenn\.dnx\runtimes
       1.0.0-beta4-11360 clr     x86          C:\Users\Glenn\.dnx\runtimes
       1.0.0-beta5-11380 clr     x86          C:\Users\Glenn\.dnx\runtimes
       1.0.0-beta5-11400 clr     x86          C:\Users\Glenn\.dnx\runtimes
  *    1.0.0-beta5-11466 clr     x86          C:\Users\Glenn\.dnx\runtimes default
</pre>


You'll need to install node. 
Note: Make sure you have a global install of both Gulp and Bower.

<pre>npm install -g gulp</pre>

<pre>npm install -g bower</pre>

To update npm on your machine use
<pre>npm update -g np</pre>
<pre>npm update -g bower</pre>
I'm now using bower 1.4 globally

to check all packages installed by npm globally
<pre>npm list -g --depth=0</pre>
<pre>
<pre>
C:\Users\Glenn>npm -g list --depth=0
C:\Users\Glenn\AppData\Roaming\npm
├── bower@1.4.1
├── grunt-cli@0.1.13
└── gulp@3.8.11
</pre>
</pre>

References:

https://github.com/gulpjs/gulp/blob/master/docs/getting-started.md

https://github.com/johnpapa/pluralsight-gulp

http://www.stoutcloud.com

I'ts here. NeoSample for the angular and WebAPI folks

Get a copy via git clone or zip. Run dnu restore and the the project will load the gulp and bower packages needed.

Run <pre>dnu restore</pre>
then in src/NeoSample run <pre>dnx . web</pre>

Browse to <pre>http://localhost:5003/clientsrc/index.html</pre> for the angular app



