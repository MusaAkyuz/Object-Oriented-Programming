import Container from 'react-bootstrap/Container';
import Nav from 'react-bootstrap/Nav';
import Navbar from 'react-bootstrap/Navbar';
import React, { Component } from 'react';
import './NavMenu.css';

export class NavbarMenu2 extends Component {
    constructor(props) {
        super(props);

        this.handleClick = this.handleClick.bind(this);
        this.backgroundClick = this.backgroundClick.bind(this);

        this.state = {
            textColor: "white",
            backgroundColor: "black",
            white: "white"
        };
    }

    handleClick = () => {
        const randomColor = Math.floor(Math.random() * 16777215).toString(16);
        this.setState({ textColor: "#" + randomColor })
    };

    backgroundClick = () => {
        const randomColor = Math.floor(Math.random() * 16777215).toString(16);
        this.setState({ backgroundColor: "#" + randomColor })
    }

    render() {
        return (
            <>
                <Navbar bg="black">
                    <Container>
                        <Nav className="">

                            <div className="stori-font pl-2 pr-2">
                                <h2>Stori</h2>
                            </div>

                        </Nav>

                        <Nav className="stori-font">

                            <form className="mx-2 form-inline" style={this.state.white ? { color: this.state.white } : white}>
                                <label className="px-2">Text color</label>
                                <button type="button"
                                        className="btn"
                                        onClick={this.handleClick}
                                        style={this.state.textColor ? {
                                            backgroundColor: this.state.textColor,
                                            color: 'transparent',
                                            border: '0.5px solid  gray'
                                    } : white}>A
                                </button>
                            </form>

                            <form className="mx-2 form-inline" style={this.state.white ? { color: this.state.white } : black}>
                                <label className="px-2">Background color</label>
                                <button type="button"
                                    className="btn"
                                    onClick={this.backgroundClick}
                                    style={this.state.backgroundColor ? {
                                        backgroundColor: this.state.backgroundColor,
                                        color: 'transparent',
                                        border: '0.5px solid  gray'
                                    } : black}>A
                                </button>
                            </form>

                        </Nav>
                    </Container>
                </Navbar>
            </>
        );
    }
}

