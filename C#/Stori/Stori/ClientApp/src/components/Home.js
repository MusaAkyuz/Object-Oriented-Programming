import { NavMenu } from './NavMenu';
import { Chapter } from './Chapter';
import axios from "axios"
import { useNavigate } from "react-router-dom";
import React, { useState, useEffect } from "react";
import './Home.css';

//export class Home extends Component {
//    static displayName = Home.name;

//    constructor(props) {
//        super(props);

//        this.handleClick = this.handleClick.bind(this);

//        this.state = {
//            textColor: "white",
//            white: "white",
//            bookNames: []
//        };
//    }

//    handleClick = () => {
//        const randomColor = Math.floor(Math.random() * 16777215).toString(16);
//        this.setState({ textColor: "#" + randomColor })
//    };

//    getBookNames = () => {
//        axios.get("/api/books").then((result) => this.setState({ bookNames: result.data }));
//        //axios.get("/api/books").then((result) => {
//        //    const allBooks = result.data.bookNamesRepo.bookName
//        //});
//    }


//    render() {
//        return (
//            <div bg="black" className="navbar-border" style={this.state.textColor != "" ? { borderBottom: this.state.textColor } : white} style={{ height: '100vh' }}>
//                <Navbar bg="black">
//                    <Container>
//                        <Nav>
//                            <div className="stori-font pl-2 pr-2">
//                                <h2>Stori</h2>
//                            </div>
//                        </Nav>

//                        <Nav className="stori-font">
//                            <form className="mx-2 form-inline" style={this.state.white ? { color: this.state.white } : white}>
//                                <label className="px-2">Text color</label>
//                                <button type="button"
//                                    className="btn"
//                                    onClick={this.handleClick}
//                                    style={this.state.textColor ? {
//                                        backgroundColor: this.state.textColor,
//                                        color: 'transparent',
//                                        border: '0.5px solid  gray'
//                                    } : white}>A
//                                </button>
//                            </form>
//                        </Nav>
//                    </Container>
//                </Navbar>

//                <div className="w-screen h-screen" style={this.state.textColor != "" ? { color: this.state.textColor } : white}>
//                    {
//                        this.state.bookNames.map((bookName, index) => (
//                            <p key={index}>{bookName.bookName}</p>
//                            ))
//                    }

//                    <p>Deneme</p>
//                </div>

//              </div>
//    );
//  }
//}

export function Home() {

    useEffect(() => { getBooks() }, [])

    const [books, setBooks] = useState([]);
    const [textColor, setTextColor] = useState("white");
    const navigate = useNavigate();
    const [bookName, setBookName] = useState(null);

    const goChapter = (bookName) => {
        setBookName(bookName);
    }

    const getBooks = () => {
        axios.get("/api/books")
             .then(response => setBooks(response.data));
    }

    const changeTextColor = data => {
        setTextColor(data);
    }

    if (bookName) {
        return (
            <Chapter bookName={bookName} />
        )
    }

    return (
        <div className="">
            <NavMenu handleTextColor={changeTextColor} />
            <div className="container">
                <div className="mx-auto flex flex-row contentCenter">
                    {
                        books.map((book, index) => {
                            return (
                                <div className="card overflow-hidden justify-center" key={index} onClick={() => goChapter(book.bookName)}>
                                    <img src={`Books/${book.bookName}/cover.jpg`} alt={book.bookName} />
                                </div>
                            );
                        })
                    }
                </div>
            </div>

        </div>
    );
}