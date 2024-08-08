import React from 'react';


const ResumeSayan = () => {
    const [htmlContent, setHtmlContent] = useState('');
  
    useEffect(() => {
      fetch('/src/html/ResumeSayan.html')
        .then((response) => response.text())
        .then((html) => {
          setHtmlContent(html);
        });
    }, []);
  
    return (
      <div dangerouslySetInnerHTML={{ __html: htmlContent }} />
    );
  };

export default ResumeSayan;