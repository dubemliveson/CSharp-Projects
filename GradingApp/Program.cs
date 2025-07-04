
int currentAssignments = 5;

int wale1 = 40;
int wale2 = 50;
int wale3 = 65;
int wale4 = 76;
int wale5 = 98;

int ann1 = 50;
int ann2 = 65;
int ann3 = 75;
int ann4 = 96;
int ann5 = 86;

int dan1 = 55;
int dan2 = 97;
int dan3 = 87;
int dan4 = 97;
int dan5 = 90;

int jong1 = 55;
int jong2 = 65;
int jong3 = 86;
int jong4 = 96;
int jong5 = 55;

int waleSum = wale1 + wale2 + wale3 + wale4 + wale5;
int annSum = ann1 + ann2 + ann3 + ann4 + ann5;
int danSum = dan1 + dan2 + dan3 + dan4 + dan5;
int jongSum = jong1 + jong2 + jong3 + jong4 + jong5;

decimal waleScore = (decimal) waleSum / currentAssignments;
decimal annScore = (decimal) annSum / currentAssignments;
decimal danScore = (decimal) danSum / currentAssignments;
decimal jongScore = (decimal) jongSum / currentAssignments;


Console.WriteLine("Student\tGrade\n");
Console.WriteLine("Wale:\t" + waleScore + "\tB");
Console.WriteLine("Ann:\t" + annScore + "\tA");
Console.WriteLine("Dan:\t" + danScore + "\tA");
Console.WriteLine("Jong:\t" + jongScore + "\tA");
