import React, { Component } from 'react';
import { Collapse, Navbar, NavbarToggler } from 'reactstrap';
import './NavMenu.css';

export class NavMenu extends Component {
    static displayName = NavMenu.name;

  constructor (props) {
    super(props);

      this.toggleNavbar = this.toggleNavbar.bind(this);
      this.handleClick = this.handleClick.bind(this);
      this.state = {
          collapsed: true,
          random: "white"
      };
  }

    handleClick = () => {
        const randomColor = Math.floor(Math.random() * 16777215).toString(16);
        this.setState({ random: "#"+ randomColor })
    };

    toggleNavbar () {
        this.setState({
            collapsed: !this.state.collapsed,
        });
    }

  render() {
    return (
      <header>
        <Navbar className="navbar-expand-sm navbar-toggleable-sm border-bottom box-shadow mb-3" container light>
                <p>
                    Stori
                </p>
          <NavbarToggler onClick={this.toggleNavbar} className="mr-2" />
          <Collapse isOpen={!this.state.collapsed} navbar>
                    <ul className="navbar-nav flex-grow">
                                <p className="" onClick={this.handleClick} style={this.state.random ? { color: this.state.random } : null}>
                                    Text-Color
                                </p>
                            
            </ul>
          </Collapse>
        </Navbar>
      </header>
    );
  }
}
