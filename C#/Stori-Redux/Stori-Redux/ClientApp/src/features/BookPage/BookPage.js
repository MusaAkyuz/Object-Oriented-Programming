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

    return (
        <div className="contentCenter">
            {   store.books ?
                store.books.map((book, index) => {
                    return (
                        <div className="book" key={index}>
                            <p>{book.id}</p>
                            <div className="cover">
                                <img src={`Books/${book.bookName}/cover.jpg`} alt={book.bookName} />
                            </div>
                        </div>   
                    )
                })
            : null}
        </div>
    );
}

export default BookPage