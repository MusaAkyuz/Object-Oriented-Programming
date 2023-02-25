import React from 'react';

import { storiesOf } from '@storybook/react';
import { action } from '@storybook/addon-actions';
import { linkTo } from '@storybook/addon-links';

import { Button, Welcome } from '@storybook/react/demo';

import * as material from 'material-colors';
import ReactCircleColorPicker from '../src';

storiesOf('Circle Color Picker', module)
  .add('Component', () => <ReactCircleColorPicker
    colors={[{ hex: material.red[500], selected: true }, { hex: material.blue[500], selected: false }, { hex: material.green[500], selected: false },
    { hex: material.white, selected: false }]}
    onChange={action('onChange')}
  />);