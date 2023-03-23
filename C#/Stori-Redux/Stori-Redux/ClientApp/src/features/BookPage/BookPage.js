import { useSelector, useDispatch } from 'react-redux'
import React, { useState, useEffect } from "react";
import axios from "axios"
import './BookPage.css'

const BookPage = () => {

    useEffect(() => { getBooks() }, [])
    const store = useSelector(state => state.AllBooks)
    const dispatch = useDispatch()

    const getBooks = () => {
        axios.get("/api/books")
            .then(response => dispatch({ type: 'bookpage/axiosget', payload: response.data }));
    }

    const selectBook = (bookName, author, chapterNumber) => {
        dispatch({ type: 'bookpage/selectbook', payload: [bookName, author, chapterNumber] })
    }

    if (store.selectedBookName && store.selectedBookAuthor && store.selectedBookChapter) {
        return (
            <p>Deneme</p>
        );
    }

    return (
        <div className="contentCenter">
            {   store.books ?
                store.books.map((book, index) => {
                    return (
                        <div className="book" key={index}>
                            <span><p>{book.bookName}</p></span>
                            <span><p>{book.author}</p></span>
                            <span><p>Chapter Number : {book.chapterNumber}</p></span>
                            <div className="cover" onClick={() => selectBook(book.bookName, book.author, book.chapterNumber)}>
                                <img src={`Books/${book.bookName}_${book.author}_${book.chapterNumber}/cover.jpg`} alt={book.bookName} />
                            </div>
                        </div>   
                    )
                })
            : null}
        </div>
    );
}

export default BookPage