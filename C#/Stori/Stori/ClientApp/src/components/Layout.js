import React, { Component } from 'react';
import { Container } from 'reactstrap';
import { NavMenu } from './NavMenu';
import {NavbarMenu2 } from './NavbarMenu2'

export class Layout extends Component {
  static displayName = Layout.name;

  render() {
      return (
      <div className="bg-black">
        <NavbarMenu2 />
        <Container>
          {this.props.children}
        </Container>
      </div>
    );
  }
}
