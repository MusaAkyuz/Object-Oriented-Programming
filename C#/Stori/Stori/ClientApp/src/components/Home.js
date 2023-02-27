import React, { Component } from 'react';


export class Home extends Component {
    static displayName = Home.name;

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

              <div style={this.state.textColor != "" ? { color: this.state.textColor } : white}>
                    <h1>Hello, world!</h1>
                    <p>Welcome to your new single-page application, built with:</p>
                    <ul>
                      <li><a href='https://get.asp.net/'>ASP.NET Core</a> and <a href='https://msdn.microsoft.com/en-us/library/67ef8sbd.aspx'>C#</a> for cross-platform server-side code</li>
                      <li><a href='https://facebook.github.io/react/'>React</a> for client-side code</li>
                      <li><a href='http://getbootstrap.com/'>Bootstrap</a> for layout and styling</li>
                    </ul>
                    <p>To help you get started, we have also set up:</p>
                    <ul>
                      <li><strong>Client-side navigation</strong>. For example, click <em>Counter</em> then <em>Back</em> to return here.</li>
                      <li><strong>Development server integration</strong>. In development mode, the development server from <code>create-react-app</code> runs in the background automatically, so your client-side resources are dynamically built on demand and the page refreshes when you modify any file.</li>
                      <li><strong>Efficient production builds</strong>. In production mode, development-time features are disabled, and your <code>dotnet publish</code> configuration produces minified, efficiently bundled JavaScript files.</li>
                    </ul>
                    <p>The <code>ClientApp</code> subdirectory is a standard React application based on the <code>create-react-app</code> template. If you open a command prompt in that directory, you can run <code>npm</code> commands such as <code>npm test</code> or <code>npm install</code>.</p>
                </div>
          </>
    );
  }
}
