# React Circle Color Picker

An simple react component for select multiple colors

## Installation & Usage

```sh
npm install react-circle-color-picker --save
```

### Include the Component

```js
import React from 'react'
import ReactCircleColorPicker from 'react-circle-color-picker'

class Component extends React.Component {

  render() {
    return <ReactCircleColorPicker colors={[{ hex: '#84947F', selected: true }, { hex: '#E53B2C', selected: false }]} />
  }
}
```