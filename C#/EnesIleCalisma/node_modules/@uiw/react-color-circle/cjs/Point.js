"use strict";

var _interopRequireWildcard = require("@babel/runtime/helpers/interopRequireWildcard")["default"];
var _interopRequireDefault = require("@babel/runtime/helpers/interopRequireDefault")["default"];
Object.defineProperty(exports, "__esModule", {
  value: true
});
exports["default"] = Point;
var _objectSpread2 = _interopRequireDefault(require("@babel/runtime/helpers/objectSpread2"));
var _react = _interopRequireWildcard(require("react"));
var _jsxRuntime = require("react/jsx-runtime");
function Point(_ref) {
  var style = _ref.style,
    title = _ref.title,
    checked = _ref.checked,
    color = _ref.color,
    onClick = _ref.onClick,
    rectProps = _ref.rectProps;
  var btn = (0, _react.useRef)(null);
  var handleMouseEnter = (0, _react.useCallback)(function (evn) {
    btn.current.style['transform'] = 'scale(1.2)';
  }, []);
  var handleMouseLeave = (0, _react.useCallback)(function (evn) {
    btn.current.style['transform'] = 'scale(1)';
  }, []);
  return /*#__PURE__*/(0, _jsxRuntime.jsx)("div", {
    ref: btn,
    onClick: onClick,
    onMouseEnter: handleMouseEnter,
    onMouseLeave: handleMouseLeave,
    title: title,
    style: (0, _objectSpread2["default"])((0, _objectSpread2["default"])({}, style), {}, {
      display: 'flex',
      alignItems: 'center',
      justifyContent: 'center',
      width: 28,
      height: 28,
      padding: 3,
      borderRadius: '50%',
      marginRight: 12,
      marginBottom: 12,
      boxSizing: 'border-box',
      transform: 'scale(1)',
      boxShadow: "".concat(color, " 0px 0px ").concat(checked ? 5 : 0, "px"),
      transition: 'transform 100ms ease 0s, box-shadow 100ms ease 0s'
    }),
    children: /*#__PURE__*/(0, _jsxRuntime.jsx)("div", (0, _objectSpread2["default"])((0, _objectSpread2["default"])({}, rectProps), {}, {
      style: (0, _objectSpread2["default"])({
        height: checked ? '100%' : 0,
        width: checked ? '100%' : 0,
        borderRadius: '50%',
        backgroundColor: '#fff',
        boxSizing: 'border-box',
        transition: 'height 100ms ease 0s, width 100ms ease 0s'
      }, rectProps.style)
    }))
  });
}
module.exports = exports.default;
//# sourceMappingURL=Point.js.map