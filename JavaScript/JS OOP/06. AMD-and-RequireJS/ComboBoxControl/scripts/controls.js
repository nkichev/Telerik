/// <reference path="libs/require.js" />
/// <reference path="libs/jquery-1.11.1.min.js" />
/// <reference path="comboBoxItem.js" />

define(['comboBoxItem', 'libs/jquery-1.11.1.min'], function (comboBoxItem) {
    var controls = (function () {
        function ComboBox(items) {
            this._items = items || [];
            this._collapsed = true;
        }

        ComboBox.prototype.render = function (template) {
            var self = this;
            var $combo = $('<div>').addClass('combo-box');
            $('body').on('click', '.person-item', function () {
                var $this = $(this);
                if (!self._collapsed) {
                    self._collapsed = true;
                    $this.parent().find('.person-item').hide();
                    $this.show();
                } else {
                    $this.parent().find('.person-item').show();
                    self._collapsed = false;
                }
            })

            $('<div>').addClass('list').appendTo($combo);
            for (var i = 0; i < this._items.length; i++) {
                $combo.html($combo.html() + comboBoxItem(this._items[i]).render(template));
                $combo.find('.person-item').hide().first().show();
            }

            return $combo.html();
        }

        return {
            ComboBox: function (items) {
                return new ComboBox(items);
            }
        };
    }());

    return controls;
});