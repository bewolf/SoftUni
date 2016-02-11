if (!Object.create) {
    Object.create = function (proto) {
        function F() {
        }

        F.prototype = proto;
        return new F();
    };
}

Object.prototype.extend = function (properties) {
    function F() {
    }

    F.prototype = Object.create(this);
    for (var prop in properties) {
        F.prototype[prop] = properties[prop];
    }
    F.prototype._super = this;
    return new F();
};
var ShapeHolder = (function () {
    var Shape = {
        init: function init(color) {
            this._color = color;
            return this;
        },
        toString: function toString() {
            return 'Color: ' + this._color;
        }
    }
    var Circle = Shape.extend({
        init: function init(x, y, radius) {
            this._super.init.call(this, '#ffffcc');
            this._x = x;
            this._y = y;
            this._radius = radius;
            return this;
        },
        toString: function toString() {
            return this._super.toString.call(this)
                + '; Center: (' + this._x + ', ' + this._y
                + '), Radius: ' + this._radius;
        }
    })
    var Triangle = Shape.extend({
        init: function init(aX, aY, bX, bY, cX, cY) {
            this._super.init.call(this, '#ff0000');
            this._aX = aX;
            this._aY = aY;
            this._bX = bX;
            this._bY = bY;
            this._cX = cX;
            this._cY = cY;
            return this;
        },
        toString: function toString() {
            return this._super.toString.call(this)
                + '; A: (' + this._aX + ', ' + this._aY
                + '), B (' + this._bX + ', ' + this._bY
                + '), C (' + this._cX + ', ' + this._cY + ')';
        }
    })
    var Rectangle = Shape.extend({
        init: function init(aX, aY, bX, bY, width, height) {
            this._super.init.call(this, '#00ff00');
            this._aX = aX;
            this._aY = aY;
            this._bX = bX;
            this._bY = bY;
            this._width = width;
            this._height = height;
            return this;
        },
        toString: function toString() {
            return this._super.toString.call(this)
                + '; A: (' + this._aX + ', ' + this._aY
                + '), B (' + this._bX + ', ' + this._bY
                + ') Width: ' + this._width + ', Height: ' + this._height;
        }
    })
    var Line = Shape.extend({
        init: function init(aX, aY, bX, bY) {
            this._super.init.call(this, '#dddddd');
            this._aX = aX;
            this._aY = aY;
            this._bX = bX;
            this._bY = bY;
            return this;
        },
        toString: function toString() {
            return this._super.toString.call(this)
                + '; A: (' + this._aX + ', ' + this._aY
                + '), B (' + this._bX + ', ' + this._bY + ')';
        }
    })
    var Segment = Shape.extend({
        init: function init(aX, aY, bX, bY) {
            this._super.init.call(this, '#cdcdcd');
            this._aX = aX;
            this._aY = aY;
            this._bX = bX;
            this._bY = bY;
            return this;
        },
        toString: function toString() {
            return this._super.toString.call(this)
                + '; A: (' + this._aX + ', ' + this._aY
                + '), B (' + this._bX + ', ' + this._bY + ')';
        }
    })
    return {
        Circle: Circle,
        Triangle: Triangle,
        Rectangle: Rectangle,
        Line: Line,
        Segment: Segment
    }
})();

var circle = ShapeHolder.Circle.init(1, 1, 5);
console.log(circle.toString());

var triangle = ShapeHolder.Triangle.init(1, 1, 2, 2, 3, 3);
console.log(triangle.toString());

var rectangle = ShapeHolder.Rectangle.init(5, 5, 6, 6, 55, 66);
console.log(rectangle.toString());

var line = ShapeHolder.Line.init(4, 4, 5, 5);
console.log(line.toString());

var segment = ShapeHolder.Segment.init(44, 44, 54, 54);
console.log(segment.toString())