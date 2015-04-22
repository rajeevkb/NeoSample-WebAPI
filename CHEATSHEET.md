
<pre>dnvm commands:</pre>

<code>dnvm  update-self</code>

<code>dnvm  list</code>

<code>dnvm  upgrade -unstable</code>

<pre>git commands:</pre>

<code>git clone https://github.com/swaggerloaf/NeoSample-WebAPI.git</code>

<code>git add CHEATSHEET.md</code>

<code>git commit -m "added CHEATSHEET.md"</code>

<code>git push -u origin master</code>


<pre>dnn/dnx commands:</pre>

<code>cd src\NeoSample</code>

<code>dnu restore</code>

<code>dnx --version</code>

<code>dnx . web</code>

<pre>entity framework commands:</pre>

<code>dnx . ef</code>

<code>dnx . ef context list</code>

<code>dnx . ef migration add CreateInititalIdentity -c NeoSample.DAL.ApplicationDbContext</code>

<code>dnx . ef migration add CreateInititalZooSchema -c NeoSample.DAL.ZooSightingDemoDb</code>

<code>dnx . ef migration apply CreateInititalZooSchema -c NeoSample.DAL.ZooSightingDemoDb</code>

<code>dnx . ef migration apply CreateInititalIdentity -c NeoSample.DAL.ApplicationDbContext</code>

<pre>code gen commands:</pre>

<pre>npm commands:</pre>

<code>npm install -g gulp</code>

<code>npm install -g bower</code>

<code>npm update -g np</code>

<code>npm update -g bower</code>

<code>npm list -g --depth=0</code>


<pre>sql script</pre>

<pre>
USE [NeoSample-WebAPI-Test]
GO

INSERT [dbo].[Zoo] ([City], [Name]) VALUES (N'Seattle', N'Seattle Zoo')
GO
INSERT [dbo].[Zoo] ([City], [Name]) VALUES (N'29 Palms', N'The Desert Zoo')
GO

INSERT [dbo].[Animal] ([Group], [Name], [Weight], [ZooId]) VALUES (1, N'Salamander', 2.5, 1)
GO
INSERT [dbo].[Animal] ([Group], [Name], [Weight], [ZooId]) VALUES (1, N'Turtle, Musk', 6.5, 2)
GO
INSERT [dbo].[Animal] ([Group], [Name], [Weight], [ZooId]) VALUES (2, N'Whale', 1000, 2)
GO
INSERT [dbo].[Animal] ([Group], [Name], [Weight], [ZooId]) VALUES (2, N'Blackfish', 3, 2)
GO
INSERT [dbo].[Animal] ([Group], [Name], [Weight], [ZooId]) VALUES (2, N'Glassfish', 3, 1)
GO
INSERT [dbo].[Animal] ([Group], [Name], [Weight], [ZooId]) VALUES (2, N'Catfish', 7, 2)
GO
INSERT [dbo].[Animal] ([Group], [Name], [Weight], [ZooId]) VALUES (2, N'Carp', 6, 1)
GO
INSERT [dbo].[Animal] ([Group], [Name], [Weight], [ZooId]) VALUES (2, N'Trout', 3, 2)
GO
INSERT [dbo].[Animal] ([Group], [Name], [Weight], [ZooId]) VALUES (2, N'Herring', 2, 1)
GO
INSERT [dbo].[Animal] ([Group], [Name], [Weight], [ZooId]) VALUES (2, N'Lungfish', 5, 2)
GO
INSERT [dbo].[Animal] ([Group], [Name], [Weight], [ZooId]) VALUES (2, N'Mackerel', 3, 1)
GO
INSERT [dbo].[Animal] ([Group], [Name], [Weight], [ZooId]) VALUES (2, N'Cod', 4, 2)
GO
INSERT [dbo].[Animal] ([Group], [Name], [Weight], [ZooId]) VALUES (2, N'Prowfish', 3, 1)
GO
</pre>
