import "./ChapterStyle.css";
import React, { useState } from "react";
import { useNavigate } from "react-router-dom";
import { useSelector, useDispatch } from 'react-redux';

const Chapter = () => {

    const dispatch = useDispatch()
    const navigate = useNavigate()
    const store = useSelector(state => state.AllBooks)
    const textStore = useSelector(state => state.TextSettings)

    const selectChapter = (data) => {
        dispatch({ type: "chapter/selectChapter", payload: data })
        navigate("/chapterText")
    }

    return (
        <div className="contentCenter" style={{ color: textStore.textColor }}>
            {
                store.chapter ? 
                store.chapter.map((chapter, index) => {
                    return (
                        <div key={index} className="card" onClick={() => selectChapter(chapter)}>
                            <img src={chapter.chapterCover} />
                            <div className="text">
                                <p>{chapter.title}</p>
                                <p>Chapter {chapter.chapterNo}</p>
                            </div>
                        </div>
                    )
                }) 
                : null
            }
            
        </div>
    );
}

export default Chapter
