import React from 'react';
import PropTypes from 'prop-types';
import CheckIcon from 'react-icons/lib/fa/check';
import InvertColor from '../util/invert-color';
import * as material from 'material-colors';

const Circle = ({ circleSize, onChange, circleSpacing, color, selected }) => {

  const styles = {
    width: circleSize,
    height: circleSize,
    backgroundColor: color,
    cursor: 'pointer',
    borderRadius: '50%',
    margin: `${circleSpacing}px`,
    boxShadow: `${color} 0px 0px 0px 14px inset`,
    transform: 'scale(1.0)',
    transition: 'transform 100ms ease',
    boxShadow: '0px 0px 2px #888888',
  };

  const checkIconStyle = {
    display: 'block',
    width: '50%',
    margin: 'auto'
  }

  const invertColor = InvertColor(color, true);

  return <div onClick={ () => { onChange? onChange(color) : null } } style={styles}>
    {selected && <CheckIcon size={circleSize} color={invertColor} style={checkIconStyle} />}
  </div>;
}

Circle.propTypes = {
  circleSize: PropTypes.number,
  circleSpacing: PropTypes.number,
  color: PropTypes.string,
  selected: PropTypes.bool,
  onChange: PropTypes.func
}

Circle.defaultProps = {
  circleSize: 28,
  circleSpacing: 3,
  color: material.black[50],
  selected: false
}

export default Circle;
