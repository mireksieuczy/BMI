double waga;
double wzrost;
double bmi;
Console.WriteLine("Podaj wage(w kg):");
waga = double.Parse(Console.ReadLine());
Console.WriteLine("Podaj wzorst(w metrach):");
wzrost = double.Parse(Console.ReadLine());
bmi = (waga / (wzrost * wzrost));
bmi = Math.Round(bmi, 2);
Console.WriteLine("Twoje BMI wynosi:{0} ", bmi);
if (bmi <= 18.5)
    Console.WriteLine("Zacznij jesc");
else if (bmi >=25)
    Console.WriteLine("Masz nadwage jebany ulancu");
else
    Console.WriteLine("Waga prawidlowa");