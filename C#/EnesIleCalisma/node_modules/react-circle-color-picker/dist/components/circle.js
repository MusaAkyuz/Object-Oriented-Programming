(function (global, factory) {
  if (typeof define === "function" && define.amd) {
    define(['exports', 'react', 'prop-types', 'react-icons/lib/fa/check', '../util/invert-color', 'material-colors'], factory);
  } else if (typeof exports !== "undefined") {
    factory(exports, require('react'), require('prop-types'), require('react-icons/lib/fa/check'), require('../util/invert-color'), require('material-colors'));
  } else {
    var mod = {
      exports: {}
    };
    factory(mod.exports, global.react, global.propTypes, global.check, global.invertColor, global.materialColors);
    global.circle = mod.exports;
  }
})(this, function (exports, _react, _propTypes, _check, _invertColor, _materialColors) {
  'use strict';

  Object.defineProperty(exports, "__esModule", {
    value: true
  });

  var _react2 = _interopRequireDefault(_react);

  var _propTypes2 = _interopRequireDefault(_propTypes);

  var _check2 = _interopRequireDefault(_check);

  var _invertColor2 = _interopRequireDefault(_invertColor);

  var material = _interopRequireWildcard(_materialColors);

  function _interopRequireWildcard(obj) {
    if (obj && obj.__esModule) {
      return obj;
    } else {
      var newObj = {};

      if (obj != null) {
        for (var key in obj) {
          if (Object.prototype.hasOwnProperty.call(obj, key)) newObj[key] = obj[key];
        }
      }

      newObj.default = obj;
      return newObj;
    }
  }

  function _interopRequireDefault(obj) {
    return obj && obj.__esModule ? obj : {
      default: obj
    };
  }

  function _defineProperty(obj, key, value) {
    if (key in obj) {
      Object.defineProperty(obj, key, {
        value: value,
        enumerable: true,
        configurable: true,
        writable: true
      });
    } else {
      obj[key] = value;
    }

    return obj;
  }

  var Circle = function Circle(_ref) {
    var circleSize = _ref.circleSize,
        onChange = _ref.onChange,
        circleSpacing = _ref.circleSpacing,
        color = _ref.color,
        selected = _ref.selected;


    var styles = _defineProperty({
      width: circleSize,
      height: circleSize,
      backgroundColor: color,
      cursor: 'pointer',
      borderRadius: '50%',
      margin: circleSpacing + 'px',
      boxShadow: color + ' 0px 0px 0px 14px inset',
      transform: 'scale(1.0)',
      transition: 'transform 100ms ease'
    }, 'boxShadow', '0px 0px 2px #888888');

    var checkIconStyle = {
      display: 'block',
      width: '50%',
      margin: 'auto'
    };

    var invertColor = (0, _invertColor2.default)(color, true);

    return _react2.default.createElement(
      'div',
      { onClick: function onClick() {
          onChange ? onChange(color) : null;
        }, style: styles },
      selected && _react2.default.createElement(_check2.default, { size: circleSize, color: invertColor, style: checkIconStyle })
    );
  };

  Circle.propTypes = {
    circleSize: _propTypes2.default.number,
    circleSpacing: _propTypes2.default.number,
    color: _propTypes2.default.string,
    selected: _propTypes2.default.bool,
    onChange: _propTypes2.default.func
  };

  Circle.defaultProps = {
    circleSize: 28,
    circleSpacing: 3,
    color: material.black[50],
    selected: false
  };

  exports.default = Circle;
});