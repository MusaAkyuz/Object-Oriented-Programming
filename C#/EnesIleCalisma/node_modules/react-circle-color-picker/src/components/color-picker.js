import React from 'react';
import PropTypes from 'prop-types';
import Circle from './circle';

class ReactCircleColorPicker extends React.Component {

    constructor(props) {
        super(props);
        this.state = {
            currentColors: props.colors
        };
        this.onChangeColor = this.onChangeColor.bind(this);
    }

    onChangeColor(colorHex) {
        let currentColors = this.state.currentColors;
        let selectedColor = currentColors.filter((color) => { return color.hex == colorHex; })[0];

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

    renderColors() {
        return this.state.currentColors.map((color, index) => {
            return <Circle circleSize={this.props.circleSize} circleSpacing={this.props.circleSpacing}
                key={index} onChange={this.onChangeColor} selected={color.selected} color={color.hex} />
        });
    }

    render() {
        var componentStyle = {
            display: 'flex',
            flexWrap: 'wrap'
        }

        return <div style={componentStyle}>
            {this.renderColors()}
        </div>;
    }

}

ReactCircleColorPicker.propTypes = {
    colors: PropTypes.arrayOf(PropTypes.shape({
        hex: PropTypes.string,
        selected: PropTypes.bool
    })),
    circleSize: PropTypes.number,
    circleSpacing: PropTypes.number,
    onChange: PropTypes.func
}

ReactCircleColorPicker.defaultProps = {
    colors: [],
    circleSize: 28,
    circleSpacing: 3,
}

export default ReactCircleColorPicker;