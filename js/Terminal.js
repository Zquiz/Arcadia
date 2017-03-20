

// JQuery code:
$(document).ready(function () {
    window.setInterval(function () {
        window.scrollTo(0, document.body.scrollHeight);
        $('#command').focus();
        if ($('#cursor').css('visibility') === 'visible') {
            $('#cursor').css({ visibility: 'hidden' });
        } else {
            $('#cursor').css({ visibility: 'visible' });
        }
    }, 500);

    $('#command').keyup(function () {

        $('#cmd span').text($(this).val());
    });

    $('#command').blur(function () {
        clearInterval(cursor);
        $('#cursor').css({ visibility: 'visible' });
    });

    // disable carriage return 
    $('#command').keydown(function (e) {
        var s = $('#command').val();
        while (s.indexOf("\n") > -1)
            s = s.replace("\n", "");
        $('#command').val(s);
    });

    $.fn.multiline = function (text) {
        this.text(text);
        this.html(this.html().replace(/\n/g, '<br/>'));
        return this;
    };

    function type(str) {
        str = str.split('').reverse();
        !function inner() {
            var delay = Math.random() * 300 + 10;
            input.value += str.pop();
            if (str.length) setTimeout(inner, delay);
            else setTimeout(prepend, delay);
        }();
    }

    function prepend(e) {
        if (e) e.preventDefault();
        var instruction = form.input.value;

        form.reset();
        body.scrollTop = body.scrollHeight;
        input.focus();
    }

    var body = document.body;
    var form = body.querySelector('form');
    var input = form.querySelector('input');

});

$.fn.enterKey = function (fnc) {
    return this.each(function () {
        $(this).keypress(function (ev) {
            var keycode = (ev.keyCode ? ev.keyCode : ev.which);
            if (keycode == '13') {
                fnc.call(this, ev);
            }
        });
    });
};



