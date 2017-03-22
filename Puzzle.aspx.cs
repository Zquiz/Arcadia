using System;
using System.Web.UI;

public partial class Puzzle : Page
{
    //Fields
    private static int _state;
    private static int _oldState;
    private static bool _answerState;
    private static int _waitState;

    /// <summary>
    ///     Page load method that will handle every fields value when the page first load
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack) return;
        ResetTerminal();
    }

    /// <summary>
    ///     Call this method if the terminal needs to get reset
    /// </summary>
    protected void ResetTerminal()
    {
        _waitState = 0;
        _oldState = 0;
        Timer1.Interval = 3000;
        Timer1.Enabled = true;
        _state = 0;
        btnSend.Enabled = false;
        command.Disabled = true;
        _answerState = false;
    }

    /// <summary>
    ///     Method with a swtich to response correct to what the player do.
    /// </summary>
    /// <param name="state"></param>
    /// <returns></returns>
    protected string AiResponse(int state)
    {
        switch (state)
        {
            case 1:
                return "root@art3mis:~!";

            case 2:
                return
                    $"{DateTime.Now:HH:mm}&lt;art3mi5&gt;:Are you there?<br />/<br />/<br />/<br />/<br />";

            case 3:
                return $"{DateTime.Now:HH:mm}&lt;art3mi5&gt;:Is anyone listening? URGENT!<br />//<br />///";
            case 4:
                Timer1.Interval = 500;
                return "Commands:<br />Yes<br />No<br />";

            case 5:
                command.Disabled = false;
                btnSend.Enabled = true;

                Timer1.Interval = 10000;
                return "root@art3mis:";

            case 6: //if yes
                _answerState = false;
                Timer1.Interval = 3000;
                _waitState = 0;
                Timer1.Enabled = true;
                command.Disabled = true;
                btnSend.Enabled = false;
                return
                    $"{DateTime.Now:HH:mm}&lt;art3mi5&gt;:I don’t have much time. I’m being watched. I’m placing my trust in you.<br />/<br />/<br />/";
            case 7: //if no
                _answerState = false;
                Timer1.Interval = 3000;
                _waitState = 0;
                Timer1.Enabled = true;
                command.Disabled = true;
                btnSend.Enabled = false;
                return
                    $"{DateTime.Now:HH:mm}&lt;art3mi5&gt;:Haha, very funny. Seriously, I’m being watched. I’m placing my trust in you.<br />/<br />/<br />/";
            case 8: //answer after yes/no has been there
                return
                    $"{DateTime.Now:HH:mm}&lt;art3mi5&gt;: My name is ART3MI5 and I work for Arcadia. Things are not what they seem.";
            case 9:
                return $"{DateTime.Now:HH:mm}&lt;art3mi5&gt;:I need you to trust me. Do you trust me?";
            case 10:
                command.Value = null;
                command.Disabled = false;
                btnSend.Enabled = true;

                Timer1.Interval = 10000;
                return "Commands:<br />Yes<br />No<br />root@art3mis:";

            case 11:
                Timer1.Enabled = true;
                _waitState = 0;
                _answerState = false;
                Timer1.Interval = 3000;
                btnSend.Enabled = false;
                command.Disabled = true;
                return //if yes
                    $"{DateTime.Now:HH:mm}&lt;art3mi5&gt;:Don’t be so trusting in this world. I know you don’t know me but I will win your trust.<br />/<br />/<br />/";
            case 12: //if no
                _answerState = false;
                Timer1.Interval = 3000;
                btnSend.Enabled = false;
                command.Disabled = true;
                _waitState = 0;
                Timer1.Enabled = true;
                return
                    $"{DateTime.Now:HH:mm}&lt;art3mi5&gt;:Good, you shouldn’t be so trusting. I know you don’t know me but I will win your trust.<br />/<br />/<br />/";
            case 13:
                return
                    $"{DateTime.Now:HH:mm}&lt;art3mi5&gt;: I can prove this to you. But it’s not safe here.<br />/<br />/<br />/";
            case 14:
                return $"{DateTime.Now:HH:mm}&lt;art3mi5&gt;: Please await further instructions.";
            case 15:
                Timer1.Enabled = false;
                command.Disabled = false;
                Response.AppendHeader("Refresh", "5;URL=Default.aspx");
                return "logging off";


            default:
                btnSend.Enabled = false;
                command.Disabled = true;
                Timer1.Enabled = true;
                _answerState = false;
                Timer1.Interval = 3000;

                return "Look, this isn’t a game. We’re being watched. I need to be able to trust you.";
        }
    }

    /// <summary>
    ///     The "game loop" of the page. When it ticks, it does some stuff that is needed to progress the glitch
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Timer1_Tick(object sender, EventArgs e)
    {
        if (_state == 5 || _state == 10) _answerState = true;

        if (!_answerState)
        {
            _waitState = 0;
            _state++;
            Literal1.Text += $"<br />{AiResponse(_state)}";
        }
        if (_answerState) Literal1.Text += $"<br />{WaitingForAnswer()}";
    }

    /// <summary>
    ///     The button event handler that will make the user able to response to the AI
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnSend_OnClick(object sender, EventArgs e)
    {
        if (command.Value.Trim().ToLower() == "kittens")
            CommandText();
        if (_state == 5)
        {
            _oldState = _state - 1;
            if (command.Value.Trim().ToLower() == "yes".ToLower().Trim())
            {
                _state = 6;
                Literal1.Text += $" {command.Value.Trim().ToLower()}<br />";
                Literal1.Text += $" {AiResponse(_state)}<br />";
                _state = 7;
            }
            else if (command.Value.Trim().ToLower() == "no".ToLower().Trim())
            {
                _state = 7;
                Literal1.Text += $" {command.Value.Trim().ToLower()}<br />";
                Literal1.Text += $" {AiResponse(_state)}<br />";
                command.Disabled = true;
                btnSend.Enabled = false;
            }
            else if (command.Value.Trim().ToLower() != "kittens")
            {
                Literal1.Text += $" {command.Value.Trim().ToLower()}<br />";

                Literal1.Text += $" {AiResponse(100000)}<br />";
                _state = _oldState;
            }
        }
        if (_state == 10)
        {
            _oldState = _state - 1;
            if (command.Value.Trim().ToLower() == "yes".ToLower().Trim())
            {
                _state = 11;
                Literal1.Text += $" {command.Value.Trim().ToLower()}<br />";
                Literal1.Text += $" {AiResponse(_state)}<br />";
                _state = 12;
            }
            else if (command.Value.Trim().ToLower() == "no".ToLower().Trim())
            {
                _state = 12;
                Literal1.Text += $" {command.Value.Trim().ToLower()}<br />";
                Literal1.Text += $" {AiResponse(_state)}<br />";
                command.Disabled = true;
                btnSend.Enabled = false;
            }
            else if (command.Value.Trim().ToLower() != "kittens")
            {
                btnSend.Enabled = false;
                command.Disabled = true;
                Timer1.Enabled = true;
                _answerState = false;
                Timer1.Interval = 3000;
                Literal1.Text += $" {command.Value.Trim().ToLower()}<br />";

                Literal1.Text +=
                    $"<br />{DateTime.Now.ToString("HH:mm")}&lt;art3mi5&gt;:Typing is a skill. Jokes aside, I will convince you to trust me.";
                _state = _oldState;
            }
        }
        command.Value = "";
    }

    /// <summary>
    ///     The waiting state that the ai can be in, when it waits for a response
    /// </summary>
    /// <returns></returns>
    protected string WaitingForAnswer()
    {
        command.Value = null;
        _waitState++;
        string returnText = null;
        if (_state == 5)
        {
            if (_waitState == 1)
                returnText =
                    $"{DateTime.Now.ToString("HH:mm")}&lt;art3mi5&gt;:Just a simple YES or NO?<br />root@art3mis:";
            if (_waitState == 2)
            {
                _state += 2;
                _answerState = false;
                btnSend.Enabled = false;
                command.Disabled = true;
                Timer1.Interval = 3000;
                returnText =
                    $"{DateTime.Now.ToString("HH:mm")}&lt;art3mi5&gt;:Fine, then I'll just type. I hope I can trust you.";
            }
        }
        else if (_state == 10)
        {
            if (_waitState == 1)
                returnText =
                    $"{DateTime.Now.ToString("HH:mm")}&lt;art3mi5&gt;:please answer YES or NO!<br />root@art3mis:";
            if (_waitState == 2)
            {
                _state += 2;
                _answerState = false;
                btnSend.Enabled = false;
                command.Disabled = true;
                Timer1.Interval = 3000;

                returnText =
                    $"{DateTime.Now.ToString("HH:mm")}&lt;art3mi5&gt;:Not much of a talker are you? Less chance of being caught I guess. But I will need your trust";
            }
        }
        return returnText;
    }

    /// <summary>
    ///     Commandtext
    /// </summary>
    protected void CommandText()
    {
        Literal1.Text += "<div class='kittens'>" +
                         "<p>	                     ,----,         ,----,                                          ,---,</p>" +
                         "<p>       ,--.                ,/   .`|       ,/   .`|                     ,--.              ,`--.' |</p>" +
                         "<p>   ,--/  /|    ,---,     ,`   .'  :     ,`   .'  :     ,---,.        ,--.'|   .--.--.    |   :  :</p>" +
                         "<p>,---,': / ' ,`--.' |   ;    ;     /   ;    ;     /   ,'  .' |    ,--,:  : |  /  /    '.  '   '  ;</p>" +
                         "<p>:   : '/ /  |   :  : .'___,/    ,'  .'___,/    ,'  ,---.'   | ,`--.'`|  ' : |  :  /`. /  |   |  |</p>" +
                         "<p>|   '   ,   :   |  ' |    :     |   |    :     |   |   |   .' |   :  :  | | ;  |  |--`   '   :  ;</p>" +
                         "<p>'   |  /    |   :  | ;    |.';  ;   ;    |.';  ;   :   :  |-, :   |   \\ | : |  :  ;_     |   |  '</p>" +
                         "<p>|   ;  ;    '   '  ; `----'  |  |   `----'  |  |   :   |  ;/| |   : '  '; |  \\  \\    `.  '   :  |</p>" +
                         "<p>:   '   \\   |   |  |     '   :  ;       '   :  ;   |   :   .' '   ' ;.    ;   `----.   \\ ;   |  ;</p>" +
                         "<p>'   : |.  \\ |   |  '     '   :  |       '   :  |   '   :  ;/| '   : |  ; .'  /  /`--'  /  `--..`;  </p>" +
                         "<p>|   | '_\\.' '   :  |     ;   |.'        ;   |.'    |   |    \\ |   | '`--'   '--'.     /  .--,_   </p>" +
                         "<p>'   : |     ;   |.'      '---'          '---'      |   :   .' '   : |         `--'---'   |    |`.  </p>" +
                         "<p>;   |,'     '---'                                  |   | ,'   ;   |.'                    `-- -`, ; </p>" +
                         "<p>'---'                                              `----'     '---'                        '---`'</p>" +
                         "<p>                                                              </p></div>";
    }
}