import "./style.css";
import React, { useState } from "react";



function RunApp() {

  const [selectedDate, setSelectedDate] = useState("");

   const title = 'Welcome to Running App'
   const inputDate = 'Input Date'
   const startTime = 'Start Time'
   const finishTime = 'Finish Time'
  
  
   
  
  const handleDateChanged = (data) => {

    setSelectedDate(data.target.value)

  }
  console.log(selectedDate)

  let get = function(){
    fetch('https://localhost:7233/api/RunningApiControllercs',{
      method: 'GET',
      dataType: 'json',
    }).then(response => response.json())
  }

  let save = function(){
    fetch('https://localhost:7233/api/RunningApiControllercs',{
      method: 'POST',
      headers: { "Content-Type": "application/json" },
      body: JSON.stringify()
      }).then(response => response.json())
  }
  return (
    <div className="title">
      <h1>{title}</h1>
      <div>
        {inputDate}<input type="date" onChange={handleDateChanged} />
        {startTime}<input className="startfield" type="time" />
        {finishTime}<input className="endfield" type="time" />
        <button className="savebutton" type="submit" onClick={save} >Submit</button>
      </div>
      <button onClick={get}>Get</button>
      <p>{get}</p>
      <ul>
        <li></li>
        <li></li>
        <li></li>
      </ul>
    </div>
  );
}

export default RunApp;
