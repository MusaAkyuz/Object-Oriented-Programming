import React, { useState, useEffect } from "react";
import { NavMenu } from './NavMenu';
import axios from "axios";
import './Home.css';

export function Chapter({ bookName }) {
    useEffect(() => { postBookName(bookName) }, [])


    const [chapterInfo, setChapterInfo] = useState([]);
    const [textColor, setTextColor] = useState("white");
    const [selectedChapter, setSelectedChapter] = useState(null);


    const changeTextColor = data => {
        setTextColor(data);
    }

    const postBookName = (data) => {
        axios.post("/api/selectedbookname", {
            bookName: data,
        }).then(response => setChapterInfo(response.data));
  
    }

    const selectChapter = (chapterNo) => {
            const equalData = async (chapterNo) =>{
                const data = chapterInfo.filter(items => items.chapterNo === chapterNo);
                await setSelectedChapter(data);
        }
        equalData(chapterNo);
    }

    if (!selectedChapter) {
        return (
            <div className="">
                <NavMenu handleTextColor={changeTextColor} />
                <div className="container">
                    <div className="mx-auto flex flex-row contentCenter">
                        {
                            chapterInfo.map((chapter, index) => {
                                return (
                                    <div className="card overflow-hidden justify-center"
                                        key={index}
                                        style={textColor != null ? { color: textColor } : "white"}
                                        onClick={() => selectChapter(chapter.chapterNo)}>
                                        <p>{chapter.chapterNo}</p>
                                        <br />
                                        <p>{chapter.title}</p>
                                        <p>{ chapter.chapterText}</p>
                                    </div>
                                );
                            })        
                        }
                    </div>
                </div>
            </div>
        );
    }
    else {
        return (
            <div>
                <NavMenu handleTextColor={changeTextColor} />
                <div className="container">
                    <div className="mx-auto flex flex-row contentCenter"
                    style={textColor != null ? { color: textColor } : "white"}                    >
                        {/*{*/}
                        {/*    selectChapter.map((chapter, index) => {*/}
                        {/*        return (*/}
                        {/*            <div className="card overflow-hidden justify-center"*/}
                        {/*                key={index}*/}
                        {/*                style={textColor != null ? { color: textColor } : "white"}>*/}
                                    
                        {/*            </div>*/}
                        {/*        );*/}
                        {/*    })*/}
                        {/*}*/}
                        <p>{selectedChapter.chepterText}</p>
                    </div>
                </div>
            </div>
        );
    }
}
