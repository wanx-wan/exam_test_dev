using System;

public class ConvertExcel
{
    public static int StrToIndex(string str_column)
    {
        int index = 0;
        for (int i = 0; i < str_column.Length; i++)
        {
            char c = str_column[i]; //character
            index = index * 26 + (c - 'A' + 1);
            //(0 * 26) + (c - 'A' + 1) = 2
        }
        return index;
    }

    public static string IndexToStr(int index)
    {
        
        string column_str = "";
        while (index > 0)
        {
            int result = (index - 1) % 26;
            //(27 - 1) % 26
            column_str = (char)('A' + result) + column_str;
            //(A + ((27 - 1) % 26) + "A")
            index = (index - 1) / 26;
            //(27 - 1) / 26
        }
        return column_str;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        string str_column = "AB";
        //(0 * 26) + ('B' - 'A' + 1) = 2
        int index = ConvertExcel.StrToIndex(str_column);
        Console.WriteLine($"{str_column} = {index}");

        int index_id = 27;
        string column_str = ConvertExcel.IndexToStr(index_id);
        Console.WriteLine($"{index_id} = {column_str}");
    }
}
