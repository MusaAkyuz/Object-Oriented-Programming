import { useSelector, useDispatch } from 'react-redux'
import React, { useState, useEffect } from "react";
import axios from "axios"
import './BookPage.css'

const BookPage = () => {

    useEffect(() => { getBooks() }, [])

    const store = useSelector(state => state.books)

    const dispatch = useDispatch()

    const getBooks = () => {
        axios.get("/api/books")
            .then(response => dispatch({ type: 'bookpage/axiosget', payload: response.data }));
    }

    return (
        <div className="contentCenter">
            {/*<div class="book" key={index}>*/}
            {/*    <p>{book.bookName}</p>*/}
            {/*    <div class="cover">*/}
            {/*        <p>{book.id}</p>*/}
            {/*    </div>*/}
            {/*</div>    */}
        </div>
    );
}

export default BookPage