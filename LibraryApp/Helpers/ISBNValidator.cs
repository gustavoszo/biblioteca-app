using System;

namespace LibraryApp.Helpers;

public class ISBNValidator
{
    private static bool ValidateISBN10(string isbn)
    {
        isbn = isbn.Replace("-", "");

        if (isbn.Length != 10)
            return false;

        int sum = 0;

        for (int i = 0; i < 9; i++)
        {
            if (!char.IsDigit(isbn[i]))
                return false;

            sum += int.Parse(isbn[i].ToString()) * (i + 1);
        }

        // Verifica o dígito verificador
        char checkDigit = isbn[9];

        if (checkDigit == 'X') // Se for 'X', representa o valor 10
            sum += 10 * 10;
        else if (char.IsDigit(checkDigit))
            sum += int.Parse(checkDigit.ToString()) * 10;
        else
            return false;

        // ISBN-10 é válido se a soma % 11 == 0
        return sum % 11 == 0;
    }

    private static bool ValidateISBN13(string isbn)
    {
        isbn = isbn.Replace("-", "");

        if (isbn.Length != 13)
            return false;

        int sum = 0;

        // Soma com os pesos para o ISBN-13
        for (int i = 0; i < 12; i++)
        {
            if (!char.IsDigit(isbn[i]))
                return false;

            // O peso alterna entre 1 e 3
            int weight = (i % 2 == 0) ? 1 : 3;

            sum += int.Parse(isbn[i].ToString()) * weight;

        }

        // Calcula o dígito verificador
        int checkDigit = (10 - (sum % 10)) % 10;

        // Verifica se o dígito verificador bate
        return checkDigit == int.Parse(isbn[12].ToString());
    }

    public static bool ValidateISBN(string isbn)
    {
        if (isbn.Length == 10)
            return ValidateISBN10(isbn);
        else if (isbn.Length == 13)
            return ValidateISBN13(isbn);

        return false;
    }
}