window.onload = function() {
  const controllers = document.querySelectorAll('.opblock-tag-section');
  controllers.forEach(function(controller) {
    const toggleButton = controller.querySelector('.opblock-tag');
    const collapsibleContent = controller.querySelector('.opblock-body');
    collapsibleContent.style.display = 'none';
    toggleButton.onclick = function() {
      if (collapsibleContent.style.display === 'none') {
        collapsibleContent.style.display = 'block';
      } else {
        collapsibleContent.style.display = 'none';
      }
    };
  });
};