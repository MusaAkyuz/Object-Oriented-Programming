import './BookPage.css'
import axios from "axios"
import React, { useEffect } from "react";
import { useNavigate } from "react-router-dom";
import { useSelector, useDispatch } from 'react-redux'

const BookPage = () => {

    useEffect(() => { getBooks() }, [])

    const dispatch = useDispatch()
    const navigate = useNavigate();
    const store = useSelector(state => state.AllBooks)

    const getBooks = () => {
        axios.get("/api/books")
            .then(response => dispatch({ type: 'bookpage/axiosget', payload: response.data }));
    }

    const selectBook = (bookName, author, chapterNumber) => {
        console.log(bookName, author, chapterNumber)
        axios.post("/api/chapter", {
            filePath: `${bookName}_${author}`
        }).then((response) =>
            dispatch({
                type: 'bookpage/getChapter',
                payload: response.data
            }));
        navigate("/chapter")
    }

    return (
        <div className="contentCenter">
            {   store.books ?
                store.books.map((book, index) => {
                    return (
                        <div className="book" key={index} onClick={() => selectBook(book.bookName, book.author, book.chapterNumber)}>
                            <span><p>{book.bookName}</p></span>
                            <span><p>{book.author}</p></span>
                            <span><p>Chapter Number : {book.chapterNumber}</p></span>
                            <div className="cover">
                                <img src={`Books/${book.bookName}_${book.author}/cover.jpg`} alt={book.bookName} />
                            </div>
                        </div>   
                    )
                })
            : null}
        </div>
    );
}

export default BookPage