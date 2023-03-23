import "./ChapterTextStyle.css";
import React, { useState } from "react";
import { useSelector, useDispatch } from 'react-redux';
import { Link, animateScroll as scroll } from "react-scroll";

const ChapterText = () => {

    const dispatch = useDispatch()
    const store = useSelector(state => state.Chapters.selectedChapter)
    const textStore = useSelector(state => state.TextSettings)


    //const onBtnClick = (type) => {
    //    switch (type) {
    //        case 'start1':
    //            myInterval = setInterval(() => scroll(1), 100)
    //            break
    //        case 'start2':
    //            myInterval = setInterval(() => scroll(20), 100)
    //            break
    //        case 'stop':
    //            clearInterval(myInterval)
    //            break
    //        case 'reverse':
    //            myInterval = setInterval(() => scroll(-10), 100)
    //            break
    //    }
    //}

    //var myInterval = setInterval(() => onBtnClick('stop'), 1000000);
    //const scroll = (speed) => {
    //    window.scrollBy({
    //        top: speed,
    //        left: 0,
    //        behavior: 'smooth'
    //    })
    //}

    //onBtnClick('start1')

    return (
        <div className="container" style={{ color: textStore.textColor }}>
            <p>
                {
                    store ? store.chapterText : null
                }
            </p>
        </div>
    );
}

export default ChapterText