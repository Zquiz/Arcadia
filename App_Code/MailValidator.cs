using System.Text.RegularExpressions;

/// <summary>
/// Class that is been called if a mail field is needed to be validated
/// </summary>
public static class MailValidator
{
    private static readonly Regex ValidEmailRegex = CreateValidEmailRegex();

    private static Regex CreateValidEmailRegex()
    {
        string validEmailPattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                                   + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                                   + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

        return new Regex(validEmailPattern, RegexOptions.IgnoreCase);
    }
    /// <summary>
    /// The method that is being called when a mail is going to be checked
    /// will use the field ValidEmailRegex that calls the method that create it. 
    /// </summary>
    /// <param name="emailAddress"></param>
    /// <returns></returns>
    public static bool EmailIsValid(string emailAddress)
    {
        bool isValid = ValidEmailRegex.IsMatch(emailAddress);

        return isValid;
    }
}