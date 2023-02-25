(function (global, factory) {
  if (typeof define === "function" && define.amd) {
    define(['exports', './components/color-picker'], factory);
  } else if (typeof exports !== "undefined") {
    factory(exports, require('./components/color-picker'));
  } else {
    var mod = {
      exports: {}
    };
    factory(mod.exports, global.colorPicker);
    global.index = mod.exports;
  }
})(this, function (exports, _colorPicker) {
  'use strict';

  Object.defineProperty(exports, "__esModule", {
    value: true
  });

  var _colorPicker2 = _interopRequireDefault(_colorPicker);

  function _interopRequireDefault(obj) {
    return obj && obj.__esModule ? obj : {
      default: obj
    };
  }

  exports.default = _colorPicker2.default;
});