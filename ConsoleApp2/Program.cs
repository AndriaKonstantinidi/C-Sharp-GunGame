using ConsoleApp2;

bowMethods bw = new bowMethods();

bw.GenerateAccuracy();
bw.GenerateArrowQuantity();
bw.bowLethal();
bw.bowPower();


gunMethods gm = new gunMethods();

gm.GenerateBullet();
gm.gunLethal();
gm.gunPower();



knifeMethods knife = new knifeMethods();

knife.KnifeLethal();
knife.KnifePower();
knife.OneOrTwo();


