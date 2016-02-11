if (!Object.create) {
    Object.create = function (proto) {
        function F() {
        }

        F.prototype = proto;
        return new F();
    };
}

Object.prototype.extends = function (parent) {
    this.prototype = Object.create(parent.prototype);
    this.prototype.constructor = this;
};

var shapeHolder = (function () {
    var Shape = (function () {
        function Shape(color) {
            if (this.constructor === Shape) {
                throw new Error('You can\'t instantiate  the abstract class Shape!');
            }
            this._color = color;
            return this;
        }

        Shape.prototype.toString = function () {
            return 'Shape: ' + this.constructor.name + ' - Color: ' + this._color;
        };
        return Shape;
    })();
    var Circle = (function () {
        var DEFAULT_CIRCLE_COLOR = '#ccc';

        function Circle(x, y, radius) {
            Shape.call(this, DEFAULT_CIRCLE_COLOR)
            this._x = x;
            this._y = y;
            this._radius = radius;
            return this;
        }

        Circle.extends(Shape);
        Circle.prototype.toString = function () {
            return Shape.prototype.toString.call(this)
                + '; Center: (' + this._x + ', ' + this._y
                + '); Radius: ' + this._radius;
        }
        return Circle;
    })();
    var Rectangle = (function () {
        var DEFAULT_RECTANGLE_COLOR = 'ff00ff';

        function Rectangle(x, y, width, height) {
            Shape.call(this, DEFAULT_RECTANGLE_COLOR);
            this._x = x;
            this._y = y;
            this._width = width;
            this._height = height;
            return this;
        };
        Rectangle.extends(Shape);
        Rectangle.prototype.toString = function () {
            return Shape.prototype.toString.call(this)
                + '; Center: (' + this._x + ', ' + this._y
                + '); Width: ' + this._width
                + ', Height: ' + this._height;
        };
        return Rectangle;

    })();
    var Triangle = (function () {
        var DEFAULT_TRIANGLE_COLOR = '#ccffcc';

        function Triangle(aX, aY, bX, bY, cX, cY) {
            Shape.call(this, DEFAULT_TRIANGLE_COLOR);
            this._aX = aX;
            this._aY = aY;
            this._bX = bX;
            this._bY = bY;
            this._cX = cX;
            this._cY = cY;
            return this;
        }

        Triangle.extends(Shape);
        Triangle.prototype.toString = function () {
            return Shape.prototype.toString.call(this)
                + '; A: (' + this._aX + ', ' + this._aY
                + '), B (' + this._bX + ', ' + this._bY
                + '), C (' + this._cX + ', ' + this._cY + ')';
        }
        return Triangle;
    })();
    var Segment = (function () {

        var DEFAULT_SEGMENT_COLOR = '#ccffff';

        function Segment(aX, aY, bX, bY) {
            Shape.call(this, DEFAULT_SEGMENT_COLOR);
            this._aX = aX;
            this._aY = aY;
            this._bX = bX;
            this._bY = bY;
            return this;
        }

        Segment.extends(Shape);
        Segment.prototype.toString = function () {
            return Shape.prototype.toString.call(this)
                + '; A: (' + this._aX + ', ' + this._aY
                + '), B (' + this._bX + ', ' + this._bY + ')';
        }
        return Segment;
    })();
    var Line = (function () {
        var DEFAULT_LINE_COLOR = '#000000'
        function Line(aX, aY, bX, bY) {
            Shape.call(this, DEFAULT_LINE_COLOR);
            this._aX = aX;
            this._aY = aY;
            this._bX = bX;
            this._bY = bY;
            return this;
        }

        Line.extends(Shape);
        Line.prototype.toString = function () {
            return Shape.prototype.toString.call(this)
                + '; A: (' + this._aX + ', ' + this._aY
                + '), B (' + this._bX + ', ' + this._bY + ')';
        }
        return Line;
    })();
    return {
        Circle: Circle,
        Rectangle: Rectangle,
        Triangle: Triangle,
        Segment: Segment,
        Line: Line
    }

})();

var circle = new shapeHolder.Circle(5, 5, 5);
console.log(circle.toString());

var rectangle = new shapeHolder.Rectangle(1, 2, 3, 4);
console.log(rectangle.toString());

var triangle = new shapeHolder.Triangle(1, 1, 2, 2, 3, 4, 4);
console.log(triangle.toString());

var segment = new shapeHolder.Segment(1, 1, 2, 2);
console.log(segment.toString());


var line = new shapeHolder.Line(1, 1, 2, 2);
console.log(line.toString());
