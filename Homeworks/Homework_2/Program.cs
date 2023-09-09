namespace Homework_2;

class Program
{
    static void Main(string[] args)
    {
        // Task №1
        Money money = new Money();
        money.SetСurrency("EUR");
        money.ChangeValueIntegerPart(10);
        money.ChangeValueFractionalPart(12);
        money.Print();

        Product product = new Product("iQos", "USD", 10, 20);
        product.Print();
        product.ChangeValues(1, 20);
        product.SetСurrency("EUR");
        product.Print();

        // Task №2

        Violin violin = new Violin("Violin", 10.2m, 14, "Вииииииии (красивый звук)", "1620", "Скрипка — смычковый музыкальный инструмент с четырьмя струнами, настроенными по квинтам: Gм D1 A1 E2. Самая высокая регистровая разновидность скрипичного семейства, ниже которой располагаются альт, виолончель и контрабас.");
        violin.Show();
        violin.Sound();
        violin.History();
        violin.Desc();

        Console.WriteLine();

        Trombone trombone = new Trombone("Trombone", 300, 1.5m, "Туууууууу", "1400", "Тромбон (итал. trombone, букв. «большая труба», англ.  и фр. trombone, нем. Posaune) — европейский духовой амбушюрный инструмент. Входит в оркестровую группу медных духовых музыкальных инструментов басово-тенорового регистра. Состоит из длинной тонкой свёрнутой металлической трубки с выдвижной кроной (кулисой), раструба, мундштука.");
        trombone.Show();
        trombone.Sound();
        trombone.History();
        trombone.Desc();

        Console.WriteLine();

        Ukulele ukulele = new Ukulele("Ukulele", 58, 25, "Трынь трынь", "1880", "Укулеле — гавайская четырёхструнная разновидность гитары, используемая для аккордового сопровождения песен и игры соло.");
        ukulele.Show();
        ukulele.Sound();
        ukulele.History();
        ukulele.Desc();

        Console.WriteLine();

        Cello cello = new Cello("Cello", 150, 51, "Ууууууууу", "1500", "Виолончель (возможно через фр. violoncelle, от итал. violoncello, уменьшит.-ласкат. от violone — «контрабасик; маленький контрабас», образованного от viola) — смычковый музыкальный инструмент с 4-мя струнами, настроенными по квинтам: Cб Gб Dм Aм. По высоте звучания занимает промежуточное положение между более высоким альтом и низким контрабасом.");
        cello.Show();
        cello.Sound();
        cello.History();
        cello.Desc();

        Console.WriteLine();

        // Task №3

        DecimalNumber decimalNumber = new DecimalNumber(102);
        Console.WriteLine(decimalNumber.ToBinary());
        Console.WriteLine(decimalNumber.ToOctal());
        Console.WriteLine(decimalNumber.ToHexadecimal());
    }
}

