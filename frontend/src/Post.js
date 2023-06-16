// https://developer.mozilla.org/en-US/docs/Web/API/Fetch_API/Using_Fetch

export const post = async (url = "", data = {}) => {
  const response = await fetch(url, {
    method: "POST",
    // mode: "cors",
    cache: "no-cache",
    // credentials: "include",
    headers: {
      "Content-Type": "application/json",
    },
    redirect: "follow", 
    referrerPolicy: "no-referrer",
    body: JSON.stringify(data),
  });
  return response.json();
}
