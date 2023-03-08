import React, { Component } from 'react';

export class Layout extends Component {
  static displayName = Layout.name;

  render() {
      return (
          <div style={{ minHeight: window.innerHeight }}>
          {this.props.children}
      </div>
    );
  }
}
