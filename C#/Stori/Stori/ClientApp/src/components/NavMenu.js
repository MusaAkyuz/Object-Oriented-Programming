import React, { Component } from 'react';
import { Navbar} from 'reactstrap';
import './NavMenu.css';

export class NavMenu extends Component {
    static displayName = NavMenu.name;

  constructor (props) {
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
      <header>
            <Navbar className="ng-white border-bottom box-shadow mb-3 bg-black"
                    container
                    dark>

                <div className="stori-font w-1/6">
                    <h2>
                        Stori
                    </h2>
                </div>

                <div className="w-1/6"
                    style={this.state.white ? { color: this.state.white } : white}>
                    <h7>Text Color </h7>
                    <button type="button"
                        class="btn"
                        onClick={this.handleClick}
                        style={this.state.textColor ? {
                            backgroundColor: this.state.textColor,
                            color: this.state.textColor,
                            border: 0
                        } : null}>A</button>
                </div>

                <div className="w-1/6"
                    style={this.state.white ? { color: this.state.white } : white}>
                    <h7>Background color </h7>
                    <button type="button"
                        class="btn"
                        onClick={this.backgroundClick}
                        style={this.state.backgroundColor ? {
                            backgroundColor: this.state.backgroundColor,
                            color: this.state.backgroundColor,
                            border: 0
                        } : null}>A</button>
                </div>
        </Navbar>
      </header>
    );
  }
}
