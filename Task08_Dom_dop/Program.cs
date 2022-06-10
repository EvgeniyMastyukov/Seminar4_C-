//Доп. задача: Напишите функцию, которая принимает слово и возвращает true, если в этом 
//слове есть две одинаковые, стоящие рядом буквы. "ссора" -> true "клюющий" -> true
// "кодер" -> false "цыпленок"-> false

Console.WriteLine("Введите любое слово: ");
string word = Console.ReadLine();
int size = word.Length;
for (int i = 0; i < size - 1; i++)
{
    char letter = word[i];

    for (int j = i + 1; j < size; j++)
    {
        if (word[j] == letter)
        {
             Console.WriteLine($"Слово {word} - true");
        }
        else
        {
            Console.WriteLine($"Слово {word} - false");
        }
        break;
    }

}


// Console.WriteLine("Введите любое слово: ");
// string word = Console.ReadLine();
// int size = word.Length;
// for (int i = 0; i < size-1; i++)
// {
//     char letter = word[i];
//     for (int j = i + 1; j < size; j++)
//     {
//         bool sovpad = word[j] == letter;       
//         Console.WriteLine(sovpad? "True":"False" );
//         break;

//     }

// }