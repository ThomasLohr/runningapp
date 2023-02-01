import './style.css';
import React, { useState } from "react";
import { useEffect } from 'react';

function RunApp() {
   const [inputDate, setInputDate] = useState(new Date().toLocaleDateString());
   const [startTime, setStartTime] = useState('00:00');
   const [finishTime, setFinishTime] = useState('00:00');

   const title = 'Welcome to Running App'
  
  const handleDateChanged = (event) => {
    setInputDate(event.target.value)
  }

  const handleStartTimeChanged = (event) =>{
    setStartTime(event.target.value)
  }

  const handleFinishTimeChanged = (event) =>{
    setFinishTime(event.target.value)
  }

  
  const [data, setData] = useState({ Name: "Thomas" })

  useEffect(() => {
    fetch('https://localhost:7233/api/Time')
    .then(res => { return res.json()})
    .then(json => { console.log(json); 
    // setData(json)
  })
  }, []);
 

  return (
    <div className="title">
      <h1>{title}</h1>
      <div>
        Date<input type="date" value={inputDate} onChange={handleDateChanged} />
        Start Time<input className="startfield" type="time" value={startTime} onChange={handleStartTimeChanged} />
        End Time<input className="endfield" type="time" value={finishTime} onChange={handleFinishTimeChanged}/>
        <button className="savebutton" type="submit" >Submit</button>
        <div>{ data.Name }</div>
      </div>
    </div>
  );
  }

export default RunApp;
