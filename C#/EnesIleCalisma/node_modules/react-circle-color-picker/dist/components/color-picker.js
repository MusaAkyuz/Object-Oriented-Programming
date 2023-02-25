(function (global, factory) {
    if (typeof define === "function" && define.amd) {
        define(['exports', 'react', 'prop-types', './circle'], factory);
    } else if (typeof exports !== "undefined") {
        factory(exports, require('react'), require('prop-types'), require('./circle'));
    } else {
        var mod = {
            exports: {}
        };
        factory(mod.exports, global.react, global.propTypes, global.circle);
        global.colorPicker = mod.exports;
    }
})(this, function (exports, _react, _propTypes, _circle) {
    'use strict';

    Object.defineProperty(exports, "__esModule", {
        value: true
    });

    var _react2 = _interopRequireDefault(_react);

    var _propTypes2 = _interopRequireDefault(_propTypes);

    var _circle2 = _interopRequireDefault(_circle);

    function _interopRequireDefault(obj) {
        return obj && obj.__esModule ? obj : {
            default: obj
        };
    }

    function _classCallCheck(instance, Constructor) {
        if (!(instance instanceof Constructor)) {
            throw new TypeError("Cannot call a class as a function");
        }
    }

    var _createClass = function () {
        function defineProperties(target, props) {
            for (var i = 0; i < props.length; i++) {
                var descriptor = props[i];
                descriptor.enumerable = descriptor.enumerable || false;
                descriptor.configurable = true;
                if ("value" in descriptor) descriptor.writable = true;
                Object.defineProperty(target, descriptor.key, descriptor);
            }
        }

        return function (Constructor, protoProps, staticProps) {
            if (protoProps) defineProperties(Constructor.prototype, protoProps);
            if (staticProps) defineProperties(Constructor, staticProps);
            return Constructor;
        };
    }();

    function _possibleConstructorReturn(self, call) {
        if (!self) {
            throw new ReferenceError("this hasn't been initialised - super() hasn't been called");
        }

        return call && (typeof call === "object" || typeof call === "function") ? call : self;
    }

    function _inherits(subClass, superClass) {
        if (typeof superClass !== "function" && superClass !== null) {
            throw new TypeError("Super expression must either be null or a function, not " + typeof superClass);
        }

        subClass.prototype = Object.create(superClass && superClass.prototype, {
            constructor: {
                value: subClass,
                enumerable: false,
                writable: true,
                configurable: true
            }
        });
        if (superClass) Object.setPrototypeOf ? Object.setPrototypeOf(subClass, superClass) : subClass.__proto__ = superClass;
    }

    var ReactCircleColorPicker = function (_React$Component) {
        _inherits(ReactCircleColorPicker, _React$Component);

        function ReactCircleColorPicker(props) {
            _classCallCheck(this, ReactCircleColorPicker);

            var _this = _possibleConstructorReturn(this, (ReactCircleColorPicker.__proto__ || Object.getPrototypeOf(ReactCircleColorPicker)).call(this, props));

            _this.state = {
                currentColors: props.colors
            };
            _this.onChangeColor = _this.onChangeColor.bind(_this);
            return _this;
        }

        _createClass(ReactCircleColorPicker, [{
            key: 'onChangeColor',
            value: function onChangeColor(colorHex) {
                var currentColors = this.state.currentColors;
                var selectedColor = currentColors.filter(function (color) {
                    return color.hex == colorHex;
                })[0];

                if (selectedColor) {
                    selectedColor.selected = !selectedColor.selected;
                    this.setState({
                        currentColors: currentColors
                    });
                }

                if (this.props.onChange) {
                    this.props.onChange(this.state.currentColors);
                }
            }
        }, {
            key: 'renderColors',
            value: function renderColors() {
                var _this2 = this;

                return this.state.currentColors.map(function (color, index) {
                    return _react2.default.createElement(_circle2.default, { circleSize: _this2.props.circleSize, circleSpacing: _this2.props.circleSpacing,
                        key: index, onChange: _this2.onChangeColor, selected: color.selected, color: color.hex });
                });
            }
        }, {
            key: 'render',
            value: function render() {
                var componentStyle = {
                    display: 'flex',
                    flexWrap: 'wrap'
                };

                return _react2.default.createElement(
                    'div',
                    { style: componentStyle },
                    this.renderColors()
                );
            }
        }]);

        return ReactCircleColorPicker;
    }(_react2.default.Component);

    ReactCircleColorPicker.propTypes = {
        colors: _propTypes2.default.arrayOf(_propTypes2.default.shape({
            hex: _propTypes2.default.string,
            selected: _propTypes2.default.bool
        })),
        circleSize: _propTypes2.default.number,
        circleSpacing: _propTypes2.default.number,
        onChange: _propTypes2.default.func
    };

    ReactCircleColorPicker.defaultProps = {
        colors: [],
        circleSize: 28,
        circleSpacing: 3
    };

    exports.default = ReactCircleColorPicker;
});