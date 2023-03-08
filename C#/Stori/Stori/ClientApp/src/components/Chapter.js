import React, { useState, useEffect } from "react";

export function Chapter({ bookName }) {

    console.log(bookName);

    return (
        <div>
            <p>{bookName}</p>
        </div>
    );

}
