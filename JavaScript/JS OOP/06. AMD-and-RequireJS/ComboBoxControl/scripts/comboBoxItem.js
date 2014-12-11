/// <reference path="libs/require.js" />
/// <reference path="libs/jquery-1.11.1.min.js" />
/// <reference path="libs/handlebars-v1.3.0.js" />

define(['libs/jquery-1.11.1.min', 'libs/handlebars-v1.3.0'], function () {
    var ComboBoxItem = (function () {
        function ComboBoxItem(item) {
            this._content = item || [];
        }

        ComboBoxItem.prototype.render = function (template) {
            var compiledTemplate = Handlebars.compile(template);
            var $item = $('<div>').addClass('combo-box-item').html(compiledTemplate(this._content));

            return $item.html();
        }

        return {
            ComboBoxItem: function (item) {
                return new ComboBoxItem(item);
            }
        };
    }());

    return ComboBoxItem.ComboBoxItem;
});