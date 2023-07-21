/*
Дана строка, содержащая только следующие символы:'(', ')', '{', '}', '[', ']'. Определите, является ли ваша строка допустимой.
Исходная строка считается допустимой при условии:
1. Открытые скобки должны быть закрыты скобками того же типа.
2. Открытые скобки должны быть закрыты в правильном порядке.
4. Каждая закрывающия скобка имеет соответствующую открытыю скобку того же типа.

Пример 1:
Входная строка: s = "()"
Результат: true

Пример 2:
Входная строка: s = "()[]{}"
Результат: true

Пример 3:
Входная строка: s = "(]"
Результат: false

Пример 4:
Входная строка: s = "()[]{()}"
Результат: true
*/

static bool IsValidString(string s)
{
    Dictionary<char, char> bracketsMap = new Dictionary<char, char>
        {
            { ')', '(' },
            { '}', '{' },
            { ']', '[' }
        };

    List<char> openBrackets = new List<char>();

    foreach (char c in s)
    {
        if (c == '(' || c == '{' || c == '[')
        {
            openBrackets.Add(c);
        }
        else if (c == ')' || c == '}' || c == ']')
        {
            if (openBrackets.Count == 0)
            {
                return false;
            }

            char top = openBrackets[openBrackets.Count - 1];
            openBrackets.RemoveAt(openBrackets.Count - 1);

            if (top != bracketsMap[c])
            {
                return false; 
            }
        }
    }

    return openBrackets.Count == 0;
}
//---------------------------------------------------------------------
Console.Write("Введите знаки: ");
string s = Console.ReadLine();
bool result = IsValidString(s);
Console.WriteLine(result);