// 3-1
/*
{
    int number;
    string input = Console.ReadLine();
    bool x = int.TryParse(input, out number);

    if (x)
    {
        Console.WriteLine("숫자입니다.");
    }
    else
    {
        Console.WriteLine("문자열입니다.");
    }
}


// 3-2

{
    int number;
    bool boolean;
    string input = Console.ReadLine();
    bool x = int.TryParse(input, out number);
    bool y = bool.TryParse(input, out boolean);

    if (x)
    {
        Console.WriteLine("숫자입니다.");
    }
    else if (y)
    {
        Console.WriteLine("불리언입니다.");
    }
    else
    {
        Console.WriteLine("문자열입니다.");
    }
}


// 3-3

{
    int number;
    string input = Console.ReadLine();
    bool x = int.TryParse(input, out number);

    if (x && (number < 100))
    {
        Console.WriteLine(number + "은(는) 100보다 작은 수 입니다.");
    }
    else if (x && (number >= 100))
    {
        Console.WriteLine(number + "은(는) 100보다 같거나 큰 수 입니다.");
    }
    else
    {
        Console.WriteLine("숫자가 아닙니다.");
    }
}


// 3-4

{
    int number;
    string input = Console.ReadLine();
    bool x = int.TryParse(input, out number);

    if (x && (number % 2) == 0)
    {
        Console.WriteLine(number + "은(는) 짝수입니다.");
    }
    else if (x && (number % 2) == 1)
    {
        Console.WriteLine(number + "은(는) 홀수입니다.");
    }
    else
    {
        Console.WriteLine("숫자가 아닙니다.");
    }
}


// 4-1

{
    int number1;
    int number2;

    Console.WriteLine("첫번째 수를 입력해 주세요.");
    string input1 = Console.ReadLine();

    Console.WriteLine("두번째 수를 입력해 주세요.");
    string input2 = Console.ReadLine();

    bool x = int.TryParse(input1, out number1);
    bool y = int.TryParse(input2, out number2);

    if (x && y)
    {
        Console.WriteLine("두 데이터는 모두 숫자입니다.");
    }
    else
    {
        Console.WriteLine("숫자가 아닙니다.");
    }
}


// 4-2

{
    int number1;
    int number2;

    Console.WriteLine("첫번째 수를 입력해 주세요.");
    string input1 = Console.ReadLine();

    Console.WriteLine("두번째 수를 입력해 주세요.");
    string input2 = Console.ReadLine();

    bool x = int.TryParse(input1, out number1);
    bool y = int.TryParse(input2, out number2);

    if (x && y)
    {
        Console.WriteLine("두 데이터는 모두 숫자입니다.");
    }
    else if (x || y)
    {
        Console.WriteLine("하나의 데이터만 숫자입니다.");
    }
    else
    {
        Console.WriteLine("두 데이터 모두 숫자가 아닙니다.");
    }
}


// 4-3

{
    int number1;
    int number2;

    Console.WriteLine("첫번째 수를 입력해 주세요.");
    string input1 = Console.ReadLine();

    Console.WriteLine("두번째 수를 입력해 주세요.");
    string input2 = Console.ReadLine();

    bool x = int.TryParse(input1, out number1);
    bool y = int.TryParse(input2, out number2);

    if (x && y)
    {
        if (number1 == number2)
        {
            Console.WriteLine(number1 + " 와(과) " + number2 + "은(는) 같습니다.");
        }
        else
        {
            if (number1 > number2)
            {
                Console.WriteLine(number1 + " 은(는) " + number2 + "보다 큽니다.");
            }
            else
            {
                Console.WriteLine(number1 + " 은(는) " + number2 + "보다 작습니다.");
            }
        }
    }
    else
    {
        Console.WriteLine("두 개의 숫자를 입력해주세요.");
    }
}


// 5-1

{
    Console.WriteLine("Q. 대한민국의 수도는 어디인가요?");
    Console.WriteLine("1.인천   2.평창   3.서울   4.부산");

    int num;
    string input = Console.ReadLine();
    bool x = int.TryParse(input, out num);

    if (x && 1 <= num && num <= 4)
    {
        if (num == 3)
        {
            Console.WriteLine("정답입니다.");
        }
        else
        {
            Console.WriteLine("오답입니다.");
        }
    }
    else if (x && num < 1 || num > 4)
    {
        Console.WriteLine("1~4의 숫자를 입력해주세요.");
    }
    else
    {
        Console.WriteLine("숫자가 아닙니다.");
    }
}


// 5-2

{
    Console.WriteLine("어디로 여행을 가고 싶나요?");
    Console.WriteLine("1.제주도   2.코타키나발루   3.싱가포르   4.태국");

    int num;
    string input = Console.ReadLine();
    bool x = int.TryParse(input, out num);

    if (x && 1 <= num && num <= 4)
    {
        switch (num)
        {
            case 1:
                Console.WriteLine("제주도는 한국의 섬으로 비교적 방문이 쉽고 다양한 놀거리/먹거리가 준비되어 있습니다.");
                break;
            case 2:
                Console.WriteLine("코타키나발루는 말레이시아 사바주의 주도로, 말레이시아 동부 보르네오섬 최대의 도시입니다.");
                break;
            case 3:
                Console.WriteLine("싱가포르는 동남아시아, 말레이 반도의 끝에 위치한 섬나라이자 항구 도시로 이루어진 도시 국가입니다.");
                break;
            case 4:
                Console.WriteLine("태국은 중국문화, 말레이문화, 불교문화, 힌두문화, 이슬람 문화가 혼재되어 있습니다. 불교적인 모습을 많이 띄지만, 문화 자체는 색다르고 스펙트럼이 넓은 형태를 띄고 있어요.");
                break;
        }
    }
    else if (x && num < 1 || num > 4)
    {
        Console.WriteLine("1~4의 숫자를 입력해주세요.");
    }
    else
    {
        Console.WriteLine("숫자가 아닙니다.");
    }
}


// 6-1
{
    for (int i=2; i<=9; i++)
    {
        Console.WriteLine("2 x " + i + " = " + 2 * i);
    }
}

// 6-2
{
    Console.WriteLine("출력하고 싶은 단을 입력해주세요.");
    string input = Console.ReadLine();
    int num;
    bool x = int.TryParse(input, out num);

    if (x)
    {
        for (int i=2; i<=9; i++)
        {
            Console.WriteLine(num + " x " + i + " = " + num * i);
        }
    }
    else
    {
        Console.WriteLine("숫자가 아닙니다.");
    }
}


// 6-3
{
    int x = 0;
    int y = 1;

    int count = 0;

    while (count < 10)
    {
        Console.Write(y + " ");
        int result = x + y;
        x = y;
        y = result;
        count++;
    }
}


// 6-4
{
    Console.WriteLine("몇개의 피보나치 수열을 출력하고 싶으신가요?");
    string input = Console.ReadLine();
    int num;
    bool x = int.TryParse(input, out num);

    if (x)
    {
        if (num > 0)
        {
            if (num >= 47)
            {
                Console.WriteLine("숫자가 너무 큽니다.");
            }
            else
            {
                int a = 0;
                int b = 1;

                int count = 0;

                while (count < num)
                {
                    Console.Write(b + " ");
                    int result = a + b;
                    a = b;
                    b = result;
                    count++;
                }
            }
        }
        else
        {
            Console.WriteLine("양수를 입력해주세요.");
        }
    }
    else
    {
        Console.WriteLine("숫자가 아닙니다.");
    }
}


// 7-1
{
    Console.WriteLine("이름을 입력해주세요. (3~10글자)");
    string input = Console.ReadLine();

    if (input.Length >= 3 && input.Length <= 10)
    {
        Console.WriteLine("안녕하세요! 제 이름은 " + input + " 입니다.");
    }
    else
    {
        Console.WriteLine("이름을 확인해주세요.");
    }
}


// 7-2
{
    bool x;

    do
    {
        Console.WriteLine("이름을 입력해주세요. (3~10글자)");
        string input = Console.ReadLine();

        if (input.Length >= 3 && input.Length <= 10)
        {
            Console.WriteLine("안녕하세요! 제 이름은 " + input + " 입니다.");
        }
        else
        {
            Console.WriteLine("이름을 확인해주세요.");
        }

        x = input.Length >= 3 && input.Length <= 10;
    }
    while (!x);
}


// 7-3
{
    bool x;

    do
    {
        Console.WriteLine("이름을 입력해주세요. (3~10글자)");
        string input = Console.ReadLine();

        Console.Clear();

        if (input.Length >= 3 && input.Length <= 10)
        {
            Console.WriteLine("안녕하세요! 제 이름은 " + input + " 입니다.");
        }
        else
        {
            Console.WriteLine("이름을 확인해주세요.");
        }

        x = input.Length >= 3 && input.Length <= 10;
    }
    while (!x);
}
*/