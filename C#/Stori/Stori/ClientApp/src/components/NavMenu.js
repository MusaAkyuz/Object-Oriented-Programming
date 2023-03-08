import Nav from 'react-bootstrap/Nav';
import Navbar from 'react-bootstrap/Navbar';
import React, { useState } from "react";
import './Home.css';

export function NavMenu({handleTextColor}) {
    const [textColor, setTextColor] = useState("white");

    const handleClick = () => {
        const randomColor = Math.floor(Math.random() * 16777215).toString(16);
        setTextColor("#" + randomColor)
        handleTextColor("#" + randomColor)
    };

    return (
        <Navbar className="bg-black pb-5">
            <div className="container">
                <Nav>
                    <div className="pl-2 pr-2">
                        <h2 className="stori-font" style={textColor != "" ? { color: textColor } : white}>Stori</h2>
                    </div>
                </Nav>

                <Nav className="text-font">
                    <form className="mx-2 form-inline" style={textColor != "" ? { color: textColor } : white}>
                        <label className="px-2">Text color</label>
                        <button type="button"
                            className="btn"
                            onClick={handleClick}
                            style={textColor ? {
                                backgroundColor: textColor,
                                color: 'transparent',
                                border: '0.5px solid  gray'
                            } : white}>A
                        </button>
                    </form>
                </Nav>
            </div>
        </Navbar>
    );
}





