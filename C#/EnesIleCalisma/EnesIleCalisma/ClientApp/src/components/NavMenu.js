import React, { Component } from 'react';
import { Collapse, Navbar, NavbarBrand, NavbarToggler, NavItem, NavLink } from 'reactstrap';
import { Link } from 'react-router-dom';
import { TwitterPicker } from 'react-color';
import './NavMenu.css';

export class NavMenu extends Component {
    static displayName = NavMenu.name;

  constructor (props) {
    super(props);

      this.toggleNavbar = this.toggleNavbar.bind(this);
      this.handleClick = this.handleClick.bind(this);
      this.state = {
          collapsed: true,
          random: "white",
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
        <Navbar className="navbar-expand-sm navbar-toggleable-sm ng-white border-bottom box-shadow mb-3 bg-white" container light>
          <NavbarBrand tag={Link} to="/">Stori</NavbarBrand>
          <NavbarToggler onClick={this.toggleNavbar} className="mr-2" />
          <Collapse className="d-sm-inline-flex flex-sm-row-reverse" isOpen={!this.state.collapsed} navbar>
                    <ul className="navbar-nav flex-grow">
                        <button className="buttonBorderless" onClick={this.handleClick} style={this.state.random ? { backgroundColor: this.state.random } : null }>
                        </button>
              <NavItem>
                <NavLink tag={Link} className="text-dark" to="/">Counter</NavLink>
              </NavItem>
              <NavItem>
                <NavLink tag={Link} className="text-dark" to="/">Fetch data</NavLink>
              </NavItem>
            </ul>
          </Collapse>
        </Navbar>
      </header>
    );
  }
}
