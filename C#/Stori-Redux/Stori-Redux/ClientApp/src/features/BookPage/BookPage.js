import { useSelector, useDispatch } from 'react-redux'
import React, { useState, useEffect } from "react";
import axios from "axios"

const BookPage = () => {

    useEffect(() => { getBooks() }, [])
    const dispatch = useDispatch()

    const getBooks = () => {
        axios.get("/api/books")
            .then(response => dispatch({ type: 'bookpage/axiosget', payload: response.data }));
    }

    return (
        <>
            <p>Denem</p>
        </>
    );
}

export default BookPage