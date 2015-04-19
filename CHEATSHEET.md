Helpful commands:
dnvm  update-self
dnvm  list
dnvm  upgrade

git clone https://github.com/swaggerloaf/NeoSample-WebAPI.git
git add CHEATSHEET.md
git commit -m "added CHEATSHEET.md"
git push -u origin master


cd src\NeoSample
dnu restore
dnx --version
dnx . web
dnx . ef
dnx . ef context list


dnx . ef migration add CreateInititalIdentity -c NeoSample.DAL.ApplicationDbContext
dnx . ef migration add CreateInititalZooSchema -c NeoSample.DAL.ZooSightingDemoDb
dnx . ef migration apply CreateInititalZooSchema -c NeoSample.DAL.ZooSightingDemoDb
dnx . ef migration apply CreateInititalIdentity -c NeoSample.DAL.ApplicationDbContext
